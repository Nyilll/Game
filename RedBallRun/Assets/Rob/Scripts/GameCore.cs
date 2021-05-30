using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameCore : MonoBehaviour
{
    public int playerScore = 0;
    public int playerHP = 120;

    public Text scoreUI;
    public Text hpUI;

    void Start()
    {
        
    }

    void Update()
    {
        scoreUI.text = playerScore.ToString();
       hpUI.text = playerHP.ToString();
    }


    public void increasePlayerScore(int value)
    {
        playerScore += value;
    }

    public void NextLevel()
    {
        
        SceneManager.LoadScene("Level_01");
    }

    public void Health(int health)
    {
        playerHP = health;
    }

    public void Recovery()
    {
        playerHP = playerHP + 20;
    } 

    public void GameOver()
    {

        SceneManager.LoadScene("GameOver");
        

    }

}

