using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scoreincrease : MonoBehaviour
{
    int score = 0;
    [SerializeField] Text Scoring;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("ScoreObject"))
        {
            score++;
            Scoring.text = "Score: " + score;
            if(score>PlayerPrefs.GetInt("HighScore",0))
            {
                PlayerPrefs.SetInt("HighScore", score);
            }
            if (score == 50)
            {
                SceneManager.LoadScene(3);
            }
        }
    }
}
