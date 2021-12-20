using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob1 : MonoBehaviour
{
    private int rnd;
    private new Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rnd = Random.Range(1, 8);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        if (rnd == 1)
        {
            Rigidbody rb = this.GetComponent<Rigidbody>();  // rigidbodyを取得
            Vector3 force = new Vector3(0, 0.8f, 0);    // 力を設定
            rb.AddForce(force);  // 力を加える
        }
        if (rnd == 2)
        {
            Rigidbody rb = this.GetComponent<Rigidbody>();  // rigidbodyを取得
            Vector3 force = new Vector3(-0.8f, 0, 0);    // 力を設定
            rb.AddForce(force);  // 力を加える
        }
        if (rnd == 3)
        {
            Rigidbody rb = this.GetComponent<Rigidbody>();  // rigidbodyを取得
            Vector3 force = new Vector3(0.8f, 0, 0);    // 力を設定
            rb.AddForce(force);  // 力を加える
        }
        if (rnd == 4)
        {
            Rigidbody rb = this.GetComponent<Rigidbody>();  // rigidbodyを取得
            Vector3 force = new Vector3(0, -0.8f, 0);    // 力を設定
            rb.AddForce(force);  // 力を加える
        }
        if (rnd == 5)
        {
            Rigidbody rb = this.GetComponent<Rigidbody>();  // rigidbodyを取得
            Vector3 force = new Vector3(-0.8f, -0.8f, 0);    // 力を設定
            rb.AddForce(force);  // 力を加える
        }
        if (rnd == 6)
        {
            Rigidbody rb = this.GetComponent<Rigidbody>();  // rigidbodyを取得
            Vector3 force = new Vector3(0.8f, -0.8f, 0);    // 力を設定
            rb.AddForce(force);  // 力を加える
        }
        if (rnd == 7)
        {
            Rigidbody rb = this.GetComponent<Rigidbody>();  // rigidbodyを取得
            Vector3 force = new Vector3(-0.8f, 0.8f, 0);    // 力を設定
            rb.AddForce(force);  // 力を加える
        }
        if (rnd == 8)
        {
            Rigidbody rb = this.GetComponent<Rigidbody>();  // rigidbodyを取得
            Vector3 force = new Vector3(0.8f, 0.8f, 0);    // 力を設定
            rb.AddForce(force);  // 力を加える
        }
    }
}
