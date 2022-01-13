using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeCounter : MonoBehaviour
{
    GameObject score;
    Score script;

    //�J�E���g�_�E��
    public float countdown = 120.0f;

    //���Ԃ�\������Text�^�̕ϐ�
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
        //���Ԃ��J�E���g�_�E������
        countdown -= Time.deltaTime;

        //���Ԃ�\������
        timeText.text = countdown.ToString("f1") + "�b";

        //countdown��0�ȉ��ɂȂ����Ƃ�
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
