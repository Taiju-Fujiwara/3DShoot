using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_back : MonoBehaviour
{
	GameObject player;

	void Start()
	{
		player = GameObject.Find("Super_Spitfire");
	}

	void Update()
	{
		Vector3 playerPos = this.player.transform.position;
		//�@�j�󂳂��ƃX�R�A�T�OUP
		if (transform.position.z <= playerPos.z - 15)
		{
			Destroy(gameObject);
		}
	}
}
