using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void Level2Game()
    {
        SceneManager.LoadScene("Level 2");
    }



    public void exitGame()
    {
        Application.Quit();
    }
}
