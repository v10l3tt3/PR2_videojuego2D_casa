using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIInicioScript : MonoBehaviour
{
    GameObject mainPanel;
    GameObject settingsPanel;

    void Start()
    {
        settingsPanel = GameObject.Find("SettingsPanel");
        settingsPanel.SetActive(false);
    }

    void Update()
    {}

    public void StartGame()
    {
        SceneManager.LoadScene("1Scene");
    }

    public void ShowSettings()
    {
        settingsPanel.SetActive(true);
    }

    public void HideSettings()
    {
        settingsPanel.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
