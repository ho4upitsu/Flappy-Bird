using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public GameObject gameOver;
    public GameObject playButton;
    void Start()
    {
        Time.timeScale = 1;
        gameOver.SetActive(false);
        playButton.SetActive(false);
    }

    public void GameOver()
    {
        gameOver.SetActive(true);
        playButton.SetActive(true);
        Time.timeScale = 0;
    }

    public void ReStartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
