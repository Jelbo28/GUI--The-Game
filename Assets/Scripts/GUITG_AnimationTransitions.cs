using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GUITG_AnimationTransitions : MonoBehaviour
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
