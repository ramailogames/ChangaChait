using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowEnemy : MonoBehaviour
{
    //comp
    Rigidbody2D rb;

    private Vector3 targetAngle = new Vector3(0f, 0f, 0f);
    private Vector3 currentAngle;
    [SerializeField] float moveSpeed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        currentAngle = transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * Time.deltaTime * moveSpeed);
        transform.Translate(-Vector2.right * Time.deltaTime * moveSpeed);
       
    }
}
