using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    public TimeCountdown _score;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (_score.ScoreCount == 1)
            {
                SceneManager.LoadScene("Credit");
                Time.timeScale = 1f;
            }
        }
    }
}
