using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private float speed = 1.0f;

    private Rigidbody2D rb = null;

    private float moveInput = 0f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.gravityScale = 5;
        rb.velocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y) * Time.deltaTime;
    }


}
