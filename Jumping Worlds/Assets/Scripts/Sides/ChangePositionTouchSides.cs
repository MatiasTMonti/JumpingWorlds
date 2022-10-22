using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePositionTouchSides : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "RightSide")
        {
            gameObject.transform.position = new Vector3(-5.25f, collision.gameObject.transform.position.y, -.5f);
        }
        else if(collision.tag == "LeftSide")
        {
            gameObject.transform.position = new Vector3(7.75f, collision.gameObject.transform.position.y, -.5f);
        }
    }
}
