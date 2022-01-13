using UnityEngine;

public class Destroy : MonoBehaviour
{

	GameObject player;

	GameObject score;
	Score script;

	
	void OnTriggerEnter(Collider other)
	{
		//　弾に当たると破壊
		if (other.gameObject.tag == "bullet")
		{
			//　破壊されるとスコア５０UP
			script.score += 50;
			Destroy(gameObject);
		}
	}

    private void OnCollisionEnter(Collision collision)
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
		score = GameObject.Find("ScoreText");
		script = score.GetComponent<Score>();
	}

	void Update()
    {
		Vector3 playerPos = this.player.transform.position;
		//　プレイヤーの後ろに行くと破壊
		if (transform.position.z <= playerPos.z - 15)
        {
			Destroy(gameObject);
		}
    }
}