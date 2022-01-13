using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob2Generate : MonoBehaviour
{
    GameObject player;

    [SerializeField]
    [Tooltip("生成するGameObject")]
    private GameObject createPrefab;
    [SerializeField]
    [Tooltip("生成する範囲A")]
    private Transform rangeA;
    [SerializeField]
    [Tooltip("生成する範囲B")]
    private Transform rangeB;

    Score script;
    GameObject score;

    // 経過時間
    private float time;

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
        Vector3 playerPos = this.player.transform.position;

        // 前フレームからの時間を加算していく
        time = time + Time.deltaTime;

        if (script.score >= 1000)
        {
            // 約3秒置きにランダムに生成されるようにする。
            if (time > 3f)
            {
                // rangeAとrangeBのx座標の範囲内でランダムな数値を作成
                float x = Random.Range(rangeA.position.x, rangeB.position.x);
                // rangeAとrangeBのy座標の範囲内でランダムな数値を作成
                float y = Random.Range(rangeA.position.y, rangeB.position.y);
                // rangeAとrangeBのz座標の範囲内でランダムな数値を作成
                float z = Random.Range(playerPos.z+150, playerPos.z + 150);

                // GameObjectを上記で決まったランダムな場所に生成
                Instantiate(createPrefab, new Vector3(x, y, z), createPrefab.transform.rotation);

                // 経過時間リセット
                time = 0f;
            }
        }
    }
}
