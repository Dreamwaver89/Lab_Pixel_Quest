using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    // Start is called before the first frame update
    // Comonents
    private Rigidbody2D _rigidbody2D;
    // forces
    public float jumpforce = 10;
    // Capsule
    public float CapsuleHeight = 0.25f;
    public float CapsuleRadius = 0.08f;


    // Gound Check
    public Transform feetCollider;
    public LayerMask groundMask;
    private bool _groundCheck;


    // Sets gravity vector and connects components

    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {  // Checks if the player is touching ground
        _groundCheck = Physics2D.OverlapCapsule(feetCollider.position,
                new Vector2(CapsuleHeight, CapsuleRadius), CapsuleDirection2D.Horizontal,
                 0, groundMask);
        // checks if player is trying to jump/can jump
        if (Input.GetKeyDown(KeyCode.Space) && _groundCheck)
        {
            _rigidbody2D.velocity = new Vector2(_rigidbody2D.velocity.x, jumpforce);
        }
    }
}