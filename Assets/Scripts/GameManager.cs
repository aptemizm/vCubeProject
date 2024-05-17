﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager: MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("locationV2");
    }
    public void InMenu()
    {
        SceneManager.LoadScene("Buntar");
    }
}
