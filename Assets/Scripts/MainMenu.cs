using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject mainMenuUI;
    [SerializeField] private GameObject settingsMenuUI;
    [SerializeField] private GameObject CreditsUI;

    public void QuitButton()
    {
        Application.Quit();
    }

    public void StartScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Main");
        Time.timeScale = 1f;
    }

    public void loadSettings()
    {
        mainMenuUI.SetActive(false);
        settingsMenuUI.SetActive(true);
    }

    public void Credits()
    {
        mainMenuUI.SetActive(false);
        CreditsUI.SetActive(true);
    }

    public void Back()
    {
        mainMenuUI.SetActive(true);
        settingsMenuUI.SetActive(false);
        CreditsUI.SetActive(false);
    }
}