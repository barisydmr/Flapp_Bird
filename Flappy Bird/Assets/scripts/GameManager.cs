using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //textler vs. i�in kullan�lan k�t�phane
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;
    public Text ScoreText;

    void Start()
    {
        ScoreText.text = 0.ToString();
        
    }

    public void updateScore()
    {
        score++;
        ScoreText.text = score.ToString();
        
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("FlappyBird");
    }
}
