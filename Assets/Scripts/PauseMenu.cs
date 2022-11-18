using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    private static bool GameIsPaused = false;
    private static bool InsideSettings = false;

    [SerializeField] private GameObject pauseMenuUI;
    [SerializeField] private GameObject settingsMenuUI;
    [SerializeField] private GameObject DiedMenuUI;
    [SerializeField] private GameObject InGameUI;
    protected internal bool isdead = false;
 
    void Update()
    {
        isdead = PlayerWithJetpack.iskilled;
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
        if (isdead == true)
            DeathPause();
    }
    public void Resume()
    {
        //Debug.Log("Resuming");
        if (InsideSettings == false)
        {
            pauseMenuUI.SetActive(false);
            InGameUI.SetActive(true);
            Time.timeScale = 1f;
            GameIsPaused = false;
        }
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        InGameUI.SetActive(false);
    }
    public void loadSettings()
    {
        //Debug.Log("Loading Settings");
        pauseMenuUI.SetActive(false);
        InGameUI.SetActive(false);
        settingsMenuUI.SetActive(true);
        InsideSettings = true;

    }
    public void Quit()
    {
        //Debug.Log("Quitting Game");
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
        InGameUI.SetActive(false);
        Time.timeScale = 0f;
    }

    public void ReTry()
    {
        DiedMenuUI.SetActive(false);
        PlayerWithJetpack.iskilled = false;
        InGameUI.SetActive(true);

        UnityEngine.SceneManagement.SceneManager.LoadScene("Main"); // Reloads Scene When ReTry.
        Time.timeScale = 1f;
    }

    public void BackToMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }
}