using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceWithPlatforms : MonoBehaviour
{
    [SerializeField] private float jumpForce = 1.0f;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0)
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * jumpForce);
        }
    }
}
