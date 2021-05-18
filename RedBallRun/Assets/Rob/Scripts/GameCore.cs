using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameCore : MonoBehaviour
{
    public int playerLives = 3;
    public int playerScore = 0;

                                                                                                                                                    /*public float totalLevelSeconds = 20f;
                                                                                                                                                    public float currentLevelSeconds;*/

    public Text scoreUI;
    public Text livesUI;

    void Start()
    {
                                                                                                                                                    /*currentLevelSeconds = totalLevelSeconds;*/
    }

    void Update()
    {
                                                                                                                                                    /* currentLevelSeconds -= Time.deltaTime;
                                                                                                                                                    if (currentLevelSeconds <= 0f)
                                                                                                                                                    {
                                                                                                                                                        Debug.Log("Time's Up");
                                                                                                                                                    } */

        scoreUI.text = playerScore.ToString();
        livesUI.text = "Lives:" + playerLives.ToString();
    }


    public void decreasePlayerLives()
    {
        playerLives--;

        if (playerLives <= 0)
        {
            Debug.Log("GAME OVER");
        }
    }

    public void increasePlayerScore(int value)
    {
        playerScore += value;
    }

    public void NextLevel()
    {
        // WaitForSeconds
        SceneManager.LoadScene("Level_01");
    }

}

/* return new yield WaitForSeconds(4f);