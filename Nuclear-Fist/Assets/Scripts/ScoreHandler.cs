using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHandler : MonoBehaviour {

    public Text text;

    private int score = 0;

    void setScore(int num) {
        score = num;
        text.text = "Score: " + score;
    }

    void addToScore(int num) {
        score += num;
        text.text = "Score: " + score;
    }

    public int getScore() {
        return score;
    }
}
