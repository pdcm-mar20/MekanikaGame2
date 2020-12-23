using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Condition : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject conditionPanel;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        pausePanel.SetActive(false);
        conditionPanel.SetActive(false);
    }

    // Update is called once per frame
    public void PauseButtonClicked()
    {
        pausePanel.SetActive(true);
        conditionPanel.SetActive(true);
        Time.timeScale = 0f;
    }
    public void ResumeButtonClicked()
    {
        pausePanel.SetActive(false);
        conditionPanel.SetActive(false);
        Time.timeScale = 1f;
    }
    public void RestartButtonClicked()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void MenuButtonClicked()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
