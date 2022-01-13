using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob2 : MonoBehaviour
{
    private new Rigidbody rigidbody;

    private GameObject player;
    private int rnd;

    

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("Super_Spitfire");
        rnd = Random.Range(1, 8);
    }

    // Update is called once per frame
    void Update()
    {
        
        // Rigidbody取得
        Rigidbody rb = this.transform.GetComponent<Rigidbody>();

        Vector3 playerPos = this.player.transform.position;
        //　プレイヤーに近づくと移動
        if (transform.position.z <= playerPos.z + 75)
        {
            if (rnd == 1)
            {
                
                    Vector3 force = new Vector3(0, 0.1f, 1.6f);    // 力を設定
                                                                   // 速度が10以下なら力を加える
                    if (rb.velocity.magnitude < 50f)
                    {
                        rb.AddForce(force); // 力を加える
                    }
                
                
            }
            if (rnd == 2)
            {
                
                    Vector3 force = new Vector3(-0.1f, 0, 1.6f);    // 力を設定
                                                                    // 速度が10以下なら力を加える
                    if (rb.velocity.magnitude < 50f)
                    {
                        rb.AddForce(force); // 力を加える
                    }
                
            }
            if (rnd == 3)
             {
                
                    Vector3 force = new Vector3(0.1f, 0, 1.6f);    // 力を設定
                                                                   // 速度が10以下なら力を加える
                    if (rb.velocity.magnitude < 50f)
                    {
                        rb.AddForce(force); // 力を加える
                    }
                
                    
            }
            if (rnd == 4)
            {
                
                    Vector3 force = new Vector3(0, -0.1f, 1.6f);    // 力を設定
                                                                    // 速度が10以下なら力を加える
                    if (rb.velocity.magnitude < 50f)
                    {
                        rb.AddForce(force); // 力を加える
                    }
                
                    
            }
            if (rnd == 5)
            {
                
                    Vector3 force = new Vector3(-0.1f, -0.1f, 1.6f);    // 力を設定
                                                                        // 速度が10以下なら力を加える
                    if (rb.velocity.magnitude < 50f)
                    {
                        rb.AddForce(force); // 力を加える
                    }
                
                    
            }
            if (rnd == 6)
            {
                
                    Vector3 force = new Vector3(0.1f, -0.1f, 1.6f);    // 力を設定
                                                                       // 速度が10以下なら力を加える
                    if (rb.velocity.magnitude < 50f)
                    {
                        rb.AddForce(force); // 力を加える
                    }
                
                    
            }
            if (rnd == 7)
            {
                
                    Vector3 force = new Vector3(-0.1f, 0.1f, 1.6f);    // 力を設定
                    // 速度が10以下なら力を加える
                    if (rb.velocity.magnitude < 50f)
                    {
                        rb.AddForce(force); // 力を加える
                    }
                
                    
            }
            if (rnd == 8)
            {
                
                    Vector3 force = new Vector3(0.1f, 0.1f, 1.6f);    // 力を設定
                    // 速度が10以下なら力を加える
                    if (rb.velocity.magnitude < 50f)
                    {
                        rb.AddForce(force); // 力を加える
                    }
   
            }
       }
    }
}
