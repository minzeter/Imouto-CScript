using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuButton : MonoBehaviour
{
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;
    }

    public void GoToFirstStage()
    {
        SceneManager.LoadScene("FirstStage");
        Time.timeScale = 1f;
    }
    public void GoToStage()
    {
        SceneManager.LoadScene("Stage");
        Time.timeScale = 1f;
    }

    public void GotoCredit()
    {
        SceneManager.LoadScene("Credit");
        Time.timeScale = 1f;
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
