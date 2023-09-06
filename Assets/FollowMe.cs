using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMe : MonoBehaviour
{
    public float speed = 5;
    void Update()
    {
        if(Input.GetKey("mouse 0"))
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = Vector2.MoveTowards(transform.position, mousePosition, speed * Time.deltaTime);
        }
        
    }
}
