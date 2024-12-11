using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;

    void update(){
        if (Input.GetKeyDown(KeyCode.Escape)) {
            Application.Quit();
        }
        
        if (Input.GetKeyDown(KeyCode.F)) {
            Screen.fullScreen = !Screen.fullScreen;
        }
    }

    [ContextMenu("addScore")]
    public void addScore(int score){
        playerScore += score;
        scoreText.text = playerScore.ToString();
    }

    public void restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver(){
        gameOverScreen.SetActive(true);
    }
    
}
