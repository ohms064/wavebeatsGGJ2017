using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
    public static ScoreManager instance;
    public Text scoreUI;
    int score;
    public Image perfectUI, niceUI, missUI;
	// Use this for initialization
	void Start () {
        instance = this;
        score = 0;
	}

    public void SetPerfect() {
        perfectUI.enabled = true;
        niceUI.enabled = false;
        missUI.enabled = false;
    }

    public void SetNice() {
        perfectUI.enabled = false;
        niceUI.enabled = true;
        missUI.enabled = false;
    }

    public void SetMiss() {
        perfectUI.enabled = false;
        niceUI.enabled = false;
        missUI.enabled = true;
    }

    public void UpdateScore(int points) {
        score += points;
        scoreUI.text = string.Format("Score: {0}", score);
    }
	
}
