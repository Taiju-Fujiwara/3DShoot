using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class Player_HP : MonoBehaviour
{
    /*
    PlayerCollision script;
    GameObject Player;

    public int player_hp;


    public GameObject hp_object = null;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Super_Spitfire");
        script = Player.GetComponent<PlayerCollision>();
    }

    // Update is called once per frame
    void Update()
    {
        player_hp = script.hp;

        Text score_hp = hp_object.GetComponent<Text>();

        score_hp.text = "HP:" + player_hp;
    }
    */

    public float hp = 20;

    public GameObject hp_object = null;

    Slider slider;

    void Start()
    {
        slider = GameObject.Find("HPSlider").GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        Text score_hp = hp_object.GetComponent<Text>();

        score_hp.text = "HP:" + hp;
        slider.value = hp;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "object")
        {
            hp -= 1;
        }
    }


}