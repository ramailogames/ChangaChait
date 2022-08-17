using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dive : MonoBehaviour
{
    Animator anim;
    [SerializeField] float diveDelay;
    [SerializeField] Rigidbody2D rb;
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
        Invoke("dive_", diveDelay);
    }

    void dive_()
    {
        rb.gravityScale = 2f;
        transform.eulerAngles = new Vector3(0, 0, 40);
        anim.SetTrigger("dive");
    }
}
