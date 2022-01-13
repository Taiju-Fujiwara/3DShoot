using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeCounter : MonoBehaviour
{
    GameObject score;
    Score script;

    //カウントダウン
    public float countdown = 120.0f;

    //時間を表示するText型の変数
    public Text timeText;

    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.Find("ScoreText");
        script = score.GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        //時間をカウントダウンする
        countdown -= Time.deltaTime;

        //時間を表示する
        timeText.text = countdown.ToString("f1") + "秒";

        //countdownが0以下になったとき
        if (countdown <= 0)
        {
            if(script.score >= 3000f)
            {
                SceneManager.LoadScene("clear_scene");
            }
            if (script.score < 3000f)
            {
                SceneManager.LoadScene("died_scene");
            }
        }
    }
}
