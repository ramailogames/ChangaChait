using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KiteMovement : MonoBehaviour
{
    //var
    [SerializeField] float moveSpeed;
    float currentMoveSpeed;
    bool isMovingRight = true;
    private Vector3 targetAngle = new Vector3(0f, 0f, 0f);
    private Vector3 currentAngle;

    //comp
    Rigidbody2D rb;
    [SerializeField] GameObject deathVfx;
    GameManager manager;


  

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        manager = FindObjectOfType<GameManager>();
    }


    // Start is called before the first frame update
    void Start()
    {



        currentMoveSpeed = moveSpeed;
        currentAngle = transform.eulerAngles;

        InvokeRepeating("IncreaseSpeed", 10f, 10f);
    }



    void FixedUpdate()
    {


        CheckAndMove();

    }

    // Update is called once per frame
    void Update()
    {

        if (!manager.hasGameStarted)
        {
            return;
        }

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


    void IncreaseSpeed()
    {
        if (manager.hasGameOver)
        {
            return;
        }
        if(currentMoveSpeed >= 10)
        {
            currentMoveSpeed = 10;
            return;
        }

        manager.scoreToAdd += 5;
        currentMoveSpeed++;
    }

    void CheckAndMove()
    {

        if (!manager.hasGameStarted)
        {
            transform.Translate(Vector2.up * Time.deltaTime * currentMoveSpeed);
            return;
        }

        if (isMovingRight)
        {
           
            transform.Translate(Vector2.up * Time.deltaTime * currentMoveSpeed);
            targetAngle.z = -80f;

            currentAngle = new Vector3(
                Mathf.LerpAngle(currentAngle.x, targetAngle.x, Time.deltaTime),
                Mathf.LerpAngle(currentAngle.y, targetAngle.y, Time.deltaTime),
                Mathf.LerpAngle(currentAngle.z, targetAngle.z, Time.deltaTime));

            transform.eulerAngles = currentAngle;
            return;
        }

      
        transform.Translate(Vector2.up * Time.deltaTime * currentMoveSpeed);
        targetAngle.z = 80f;

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
            manager.hasGameOver = true;
            Debug.Log(collision.gameObject.name);
            Instantiate(deathVfx, transform.position, transform.rotation);
            FindObjectOfType<AudioManagerCS>().Play("pop");
            manager.Invoke_ShowGameOver();
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }



}
