using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public int hp = 10;
    
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "object")
        {
            hp -= 1;
        }
    }
}
