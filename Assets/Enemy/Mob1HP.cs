using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob1HP : MonoBehaviour
{
    GameObject score;
    Score script;

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "bullet")
        {
            script.score += 100;
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
       score = GameObject.Find("ScoreText");
        script = score.GetComponent<Score>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
