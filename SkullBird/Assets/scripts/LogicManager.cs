using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManager : MonoBehaviour
{

    public int playerScore = 0;
    public Text scoreText;
    public GameObject gameOverScene;
    
    [ContextMenu("Add Player Score")]
    public void AddScore()
    {
        playerScore += 1;
        scoreText.text = playerScore.ToString();

        FindObjectOfType<AudioManagerScript>().PlayAudio("addScore");
    }


    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        FindObjectOfType<AudioManagerScript>().PlayAudio("menuClick");
    }

    [ContextMenu("Set game over")]
    public void GameOver()
    {
        gameOverScene.SetActive(true);

        FindObjectOfType<AudioManagerScript>().PlayAudio("gameOver");

    }

}
