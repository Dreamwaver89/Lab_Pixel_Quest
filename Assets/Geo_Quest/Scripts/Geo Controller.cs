using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeoController : MonoBehaviour
{
    string variable = "Hello";
    Rigidbody2D bill;
    /* 
     hello bro
     */
    public float Dell;


    // Start is called before the first frame update
    void Start() {
        bill = GetComponent<Rigidbody2D>();

        Debug.Log("Hello World");

        string variable2 = "World" + variable;

            }
    // Update is called once per frame
    void Update()
    {
        // bill.velocity = new Vector2(1, bill.velocity.y);

        //yfyfyufgy
        if (Input.GetKey(KeyCode.D))
        {
            bill.velocity = new Vector2(Dell, bill.velocity.y);
        }
        else {
        bill.velocity = new Vector2(0, bill.velocity.y);
        
        }
        if (Input.GetKey(KeyCode.A))
        {
            bill.velocity = new Vector2(-Dell, bill.velocity.y);
        }
    
    }   

} 
    

