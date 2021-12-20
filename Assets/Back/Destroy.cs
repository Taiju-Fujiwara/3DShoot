using UnityEngine;

public class Destroy : MonoBehaviour
{

	GameObject player;

	/// <summary>
	/// 衝突した時
	/// </summary>
	/// <param name="collision"></param>
	void OnCollisionEnter(Collision collision)
	{
		// 衝突した相手にPlayerタグが付いているとき
		if (collision.gameObject.tag == "Player")
		{
			Destroy(gameObject);
		}
	}

	void Start()
	{
		player = GameObject.Find("Super_Spitfire");
	}

	void Update()
    {
		Vector3 playerPos = this.player.transform.position;
		if (transform.position.z <= playerPos.z - 15)
        {
			Destroy(gameObject);
		}
    }
}