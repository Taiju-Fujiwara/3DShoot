using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBack3 : MonoBehaviour
{
    GameObject player;

    [SerializeField]
    [Tooltip("生成するGameObject")]
    private GameObject createPrefab;
    [SerializeField]
    [Tooltip("生成する範囲D")]
    private Transform rangeD;
    [SerializeField]
    [Tooltip("生成する範囲G")]
    private Transform rangeG;

    // 経過時間
    private float time;


    void Start()
    {
        player = GameObject.Find("Super_Spitfire");
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = this.player.transform.position;

        // 前フレームからの時間を加算していく
        time = time + Time.deltaTime;

        // 約1秒置きにランダムに生成されるようにする。
        if (time > 2.75f)
        {
            // rangeAとrangeBのx座標の範囲内でランダムな数値を作成
            float x = Random.Range(rangeD.position.x, rangeG.position.x);
            // rangeAとrangeBのy座標の範囲内でランダムな数値を作成
            float y = Random.Range(rangeD.position.y, rangeG.position.y);
            // rangeAとrangeBのz座標の範囲内でランダムな数値を作成
            float z = Random.Range(playerPos.z + 20, playerPos.z + 250);

            // GameObjectを上記で決まったランダムな場所に生成
            Instantiate(createPrefab, new Vector3(x, y, z), createPrefab.transform.rotation);

            // 経過時間リセット
            time = 0f;
        }
    }
}