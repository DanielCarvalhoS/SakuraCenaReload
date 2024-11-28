using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Missao");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Missao1()
    {
        SceneManager.LoadScene("City");
    }

    public void Retentar()
    {
        SceneManager.LoadScene("LutaBoss");
    }
    public void Menuzin()
    {
        SceneManager.LoadScene("Menu");
    }
}




