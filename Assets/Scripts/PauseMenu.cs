using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject settingsMenuUI;
    public GameObject DiedMenuUI;
    public static bool InsideSettings = false;
    private bool isdead = false;

    // Update is called once per frame
    void Update()
    {
        isdead = PlayerMovement.iskilled;
        if (Input.GetButtonDown("Menu") && isdead != true)
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
        if (isdead == true) // Died Hitting Something Specififed Tag call in Death Menu.
            DeathPause();
    }
    public void Resume()
    {
        Debug.Log("Resuming");
        if (InsideSettings == false)
        {
            pauseMenuUI.SetActive(false);
            Time.timeScale = 1f;
            GameIsPaused = false;
        }
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f; // Freeze Game
        GameIsPaused = true;
    }
    public void loadSettings()
    {
        Debug.Log("Loading Settings");
        pauseMenuUI.SetActive(false);
        settingsMenuUI.SetActive(true);
        InsideSettings = true;

    }
    public void Quit()
    {
        Debug.Log("Quitting Game");
        Application.Quit();
    }

    public void Back()
    {
        pauseMenuUI.SetActive(true);
        settingsMenuUI.SetActive(false);
        InsideSettings = false;
    }

    public void DeathPause()
    {
        DiedMenuUI.SetActive(true);
        Time.timeScale = 0f; // Freeze Game
    }

    public void ReTry()
    {
        DiedMenuUI.SetActive(false);
        Debug.Log("Retried");
        PlayerMovement.iskilled = false; // Reset the Character To not be dead xD

        UnityEngine.SceneManagement.SceneManager.LoadScene("Main"); // Reloads the Scene When Player Clicks ReTry.
        Time.timeScale = 1f; // Freeze Game
    }

    public void BackToMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }
}
