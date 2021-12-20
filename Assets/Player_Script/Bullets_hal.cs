using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullets_hal : MonoBehaviour
{
    ShootingRight script;
    GameObject Bullets;

    public GameObject bullets_object = null;
    // Start is called before the first frame update
    void Start()
    {
        Bullets = GameObject.Find("Super_Spitfire");
        script = Bullets.GetComponent<ShootingRight>();
    }

    // Update is called once per frame
    void Update()
    {
        int player_bullets = script.bullets;

        Text text_bullets = bullets_object.GetComponent<Text>();

        text_bullets.text = "Bullets:" + player_bullets;
    }
}
