using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootingRight : MonoBehaviour
{
    // bullet prefab
    public GameObject bullet;

    // 弾丸発射点（右）
    public Transform muzzle_right;

    // 弾丸発射点（右）
    public Transform muzzle_left;

    // 弾丸の速度
    public float speed = 10000;

    // 射撃間隔
    int rate = 0;

    // 弾数
    public int bullets = 100;

    // 射撃判断
    bool Judgment = true;

    // テキスト表示
    public GameObject bullet_object = null;

    // 弾数ゲージ
    Slider slider;

    //テキスト表示（リロード中）
    [SerializeField] GameObject text;

    public AudioClip sound1;
    AudioSource audioSource;
    bool on = true;

    // Use this for initialization
    void Start()
    {
        slider = GameObject.Find("BulletSlider").GetComponent<Slider>();
        //Componentを取得
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Text text_bullet = bullet_object.GetComponent<Text>();

        //　残弾表示
        text_bullet.text = "残弾:" + bullets;
        slider.value = bullets;

        rate -= 1;

        if (Input.GetKey(KeyCode.Mouse0) && rate <= 0 && Judgment == true)
        {
            on = true;
            Fire();
            if (on == true)
            {
                audioSource.PlayOneShot(sound1);
                on = false;
            }
        }
        if (Input.GetKey(KeyCode.R))
        {
            Judgment = false;

            text.SetActive(true);

            Invoke("Reload", 1.5f);
        }
    }

    void Reload()
    {
        bullets = 100;

        if (Judgment == false)
        {
            Judgment = true;
        }

        text.SetActive(false);
    }
    void Fire()
    {
        // 弾丸の複製
        GameObject bullets_left = Instantiate(bullet) as GameObject;
        Vector3 force_left;

        force_left = this.gameObject.transform.forward * speed;

        // Rigidbodyに力を加えて発射
        bullets_left.GetComponent<Rigidbody>().AddForce(force_left);

        // 弾丸の位置を調整
        bullets_left.transform.position = muzzle_left.position;

        // 弾丸の複製
        GameObject bullets_right = Instantiate(bullet) as GameObject;

        Vector3 force_right;

        force_right = this.gameObject.transform.forward * speed;

        // Rigidbodyに力を加えて発射
        bullets_right.GetComponent<Rigidbody>().AddForce(force_right);

        // 弾丸の位置を調整
        bullets_right.transform.position = muzzle_right.position;

        rate = 30;

        bullets -= 2;

        if (bullets <= 0)
        {
            Judgment = false;
        }
    }
}