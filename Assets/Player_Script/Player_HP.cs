using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player_HP : MonoBehaviour
{
    public float hp = 75;

    public GameObject hp_object = null;

    Slider slider;

    void Start()
    {
        slider = GameObject.Find("HPSlider").GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        Text text_hp = hp_object.GetComponent<Text>();

        text_hp.text = "HP:" + hp;
        slider.value = hp;
        if(hp <= 0)
        {
            //　死亡時死亡シーンに遷移
            SceneManager.LoadScene("died_scene");
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        //　オブジェクトとの衝突判定
        if (collision.gameObject.tag == "object")
        {
            hp -= 1;
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "enemybullet")
        {
            hp -= 1;
        }

        if (collider.gameObject.tag == "enemy")
        {
            hp -= 1;
        }
    }
    
}