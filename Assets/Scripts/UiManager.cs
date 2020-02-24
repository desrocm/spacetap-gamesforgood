using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    public static UiManager instance;
    public GameObject gameOverPanel;
    public Text scoreText;
    public GameObject startUi;
    public GameObject gameOverText;
    public Text highScoreText;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = ScoreManager.instance.score.ToString();
    }
    public void GameStart()
    {
        startUi.SetActive(false);
    }
    public void GameOver()
    {
        gameOverText.SetActive(true);
        highScoreText.text = "HIGH SCORE : "+ PlayerPrefs.GetInt("HighScore");
        gameOverPanel.SetActive(true);
    }
    public void Replay()
    {
        SceneManager.LoadScene ("Level1");
    }
    public void Menu()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
