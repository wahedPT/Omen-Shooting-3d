using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    public GameObject optionPanel, topPanel, MenuPanel, HelpPanel;


    public void optionMenu()
    {
        optionPanel.SetActive(true);
        topPanel.SetActive(false);
        MenuPanel.SetActive(false);
        HelpPanel.SetActive(false);

    }
    public void back()
    {
        optionPanel.SetActive(false);
        topPanel.SetActive(true);
        MenuPanel.SetActive(true);
        HelpPanel.SetActive(false);
    }
    public void Help()
    {
        optionPanel.SetActive(false);
        topPanel.SetActive(false);
        MenuPanel.SetActive(false);
        HelpPanel.SetActive(true);

    }
    public void Paly()
    {
        SceneManager.LoadScene(1);
        optionPanel.SetActive(false);
        topPanel.SetActive(false);
        MenuPanel.SetActive(false);
        HelpPanel.SetActive(false);
    }

  
}
