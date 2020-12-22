using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainPanel;
    public GameObject creditPanel;
    // Start is called before the first frame update
    void Start()
    {
        mainPanel.SetActive(true);
        creditPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayButtonClicked()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void creditButtonClicked()
    {
        mainPanel.SetActive(false);
        creditPanel.SetActive(true);
    }
    public void backButtonClicked()
    {
        mainPanel.SetActive(true);
        creditPanel.SetActive(false);
    }
    public void exitButtonClicked()
    {
        Application.Quit();
    }
}