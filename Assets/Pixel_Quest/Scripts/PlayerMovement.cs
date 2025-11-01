using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour

{ private SpriteRenderer _SpriteRenderer;            //  Controls player image
    public float xMultiplier = 4;                    //   Controlls player physics
    private Rigidbody2D _rigidbody2D;                 //  Controls player X speed
    Rigidbody2D bill;
    /* 
     hello bro
     */
    public float Dell;


    // Start is called before the first frame update
   private void Start(){ 
    
        bill = GetComponent<Rigidbody2D>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _SpriteRenderer = transform.GetChild(0).GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void Update(){
          // Get player movement from player button press
        bill.velocity = new Vector2(Dell * Input.GetAxis("Horizontal"), bill.velocity.y);
        float xMovement = Input.GetAxis("Horizontal");



        if (xMovement > 0){ _SpriteRenderer.flipX = true; }
        else if (xMovement < 0) { _SpriteRenderer.flipX = false; }

        // Give the speed to the rigidbody
        _rigidbody2D.velocity = new Vector2(xMultiplier * xMovement, _rigidbody2D.velocity.y);
    }
}
