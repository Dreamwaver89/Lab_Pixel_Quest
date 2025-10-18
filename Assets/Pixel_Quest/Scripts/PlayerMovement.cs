using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    Rigidbody2D bill;
    /* 
     hello bro
     */
    public float Dell;

    // Start is called before the first frame update
    void Start()
    {
        bill = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        bill.velocity = new Vector2(Dell * Input.GetAxis("Horizontal"), bill.velocity.y);
    }
}
