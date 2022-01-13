using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob2Shoot : MonoBehaviour
{
    public GameObject player;
    public GameObject bullet;
    public float ballSpeed = 25.0f;

    bool shoot = true;



    // Start is called before the first frame update
    void Start()
    {
        transform.LookAt(player.transform);
        player = GameObject.Find("Target");
        //�@�ˌ��J�n
        StartCoroutine("BallShot");
        //�@�T�b��Ɏˌ��I�����ړ��J�n
        Invoke("judgement", 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        //�@�v���C���[�Ɍ����ď�����]
        transform.LookAt(player.transform);
    }

    IEnumerator BallShot()
    {
        while (shoot)
        {
            var shot = Instantiate(bullet, transform.position, Quaternion.identity);
            shot.GetComponent<Rigidbody>().velocity = transform.forward.normalized * ballSpeed;
            yield return new WaitForSeconds(1f);
        }
    }
    void judgement()
    {
        if (shoot == false)
        {
            shoot = true;
        }
    }
}
