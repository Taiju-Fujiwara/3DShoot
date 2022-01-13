using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob2HP : MonoBehaviour
{
    public float mob2hp = 3;
    GameObject player;

    GameObject score;
    Score script;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Super_Spitfire");
        score = GameObject.Find("ScoreText");
        script = score.GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        if (mob2hp <= 0)
        {
            script.score += 250;
            Destroy(gameObject);
        }
        Vector3 playerPos = this.player.transform.position;
        if (transform.position.z >= playerPos.z + 150)
        {
            Destroy(gameObject);
        }
    }

    public void OnTriggerEnter(Collider collider)
    {
        //　弾に重なるとダメージ
        if (collider.gameObject.tag == "bullet")
        {
            mob2hp -= 1;
        }
    }
}
