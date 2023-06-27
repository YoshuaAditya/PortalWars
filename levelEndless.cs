using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class levelEndless : MonoBehaviour {


    public int score;
    public string TagList = "|Monster|";
    public Text scoreText;

    // Use this for initialization
    void Start () {
        score = 0;
        updateScore();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnTriggerEnter2D(Collider2D other)
    {
        // If the tag of the colliding object is allowed to teleport
        if (TagList.Contains("|Monster|"))
        {
            Destroy(other.gameObject);
            score -= 10;
        }
    }

    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        updateScore();
    }

    void updateScore()
    {
        scoreText.text += "SCORE :    " + score;
    }
}
