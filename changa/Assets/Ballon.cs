using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballon : MonoBehaviour
{
    [SerializeField] float maxSpeed, minSpeed;
    float currentSpeed;
    // Start is called before the first frame update
    void Start()
    {
        currentSpeed = Random.Range(minSpeed, maxSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * currentSpeed * Time.deltaTime);
    }
}
