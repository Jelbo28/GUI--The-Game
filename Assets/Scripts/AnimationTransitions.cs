﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class AnimationTransitions : MonoBehaviour
{
    public void LoadLevel()
    {
        SceneManager.LoadScene("Level");
    }


    public void EndGame()
    {
        Application.Quit();
    }

    public void Menu()
    {
        SceneManager.LoadScene("Title");
    }
}
