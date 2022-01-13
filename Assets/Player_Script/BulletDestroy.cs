using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy: MonoBehaviour
{
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("Super_Spitfire");  
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = this.player.transform.position;

        //　プレイヤーから離れると破壊
        if (transform.position.z >= playerPos.z + 75)
        {
            Destroy(gameObject);
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            Destroy(gameObject);
        }
        if(collision.gameObject.tag == "bullet")
        {
            Destroy(gameObject);
        }
    }

}
