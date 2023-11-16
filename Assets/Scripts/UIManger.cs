using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;


public class UIMangaer : MonoBehaviour
{
    void Awake() {
        Application.targetFrameRate = 60;

    }
    public void restart() {
        ScoreTracker.score = 10000;
        SceneManager.LoadScene("Title");
    }
    public void easyMode() {
        SceneManager.LoadScene("Easy");
    }

    public void mediumMode() {
        ScoreTracker.TNTscore = 50;
        SceneManager.LoadScene("Medium");
    }

    public void hardMode() {
        ScoreTracker.TNTscore = 10;
        SceneManager.LoadScene("Hard");
    }
}