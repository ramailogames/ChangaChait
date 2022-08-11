using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KiteMovement : MonoBehaviour
{
    //var
    [SerializeField] float moveSpeed;
    bool isMovingRight = true;
    private Vector3 targetAngle = new Vector3(0f, 0f, 0f);
    private Vector3 currentAngle;

    //comp
    Rigidbody2D rb;
    [SerializeField] GameObject deathVfx;



  

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    // Start is called before the first frame update
    void Start()
    {
       

 
      
        currentAngle = transform.eulerAngles;
    }



    void FixedUpdate()
    {


        CheckAndMove();

    }

    // Update is called once per frame
    void Update()
    {

     

        if (Input.GetMouseButtonDown(0))
        {
            if (Input.mousePosition.x < Screen.width / 2)
            {
                isMovingRight = false;


            }

            if (Input.mousePosition.x > Screen.width / 2)
            {
                isMovingRight = true;

            }

        }


    }

    void CheckAndMove()
    {
        if (isMovingRight)
        {
           
            transform.Translate(Vector2.down * Time.deltaTime * moveSpeed);
            targetAngle.z = 80f;

            currentAngle = new Vector3(
                Mathf.LerpAngle(currentAngle.x, targetAngle.x, Time.deltaTime),
                Mathf.LerpAngle(currentAngle.y, targetAngle.y, Time.deltaTime),
                Mathf.LerpAngle(currentAngle.z, targetAngle.z, Time.deltaTime));

            transform.eulerAngles = currentAngle;
            return;
        }

      
        transform.Translate(Vector2.down * Time.deltaTime * moveSpeed);
        targetAngle.z = -80f;

        currentAngle = new Vector3(
            Mathf.LerpAngle(currentAngle.x, targetAngle.x, Time.deltaTime),
            Mathf.LerpAngle(currentAngle.y, targetAngle.y, Time.deltaTime),
            Mathf.LerpAngle(currentAngle.z, targetAngle.z, Time.deltaTime));

        transform.eulerAngles = currentAngle;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Instantiate(deathVfx, transform.position, transform.rotation);
            FindObjectOfType<AudioManagerCS>().Play("pop");
            FindObjectOfType<GameManager>().Invoke_ShowGameOver();
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }



}
