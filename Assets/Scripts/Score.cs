using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    private int score;
    public int ballValue = 1;
    public Text scoreText;

	// Use this for initialization
	void Start () {
        score = 0;
        UpdateText();
	}

    private void OnTriggerEnter2D(Collider2D other) {
        score = score + ballValue;
        UpdateText();
        Destroy(other.gameObject);
    }
	
    private void UpdateText() {
        scoreText.text = "Score: " + score;
    }

	// Update is called once per frame
	void Update () {
	    
	}
}
