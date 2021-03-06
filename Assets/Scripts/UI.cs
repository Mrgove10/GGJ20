using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;


public class UI : MonoBehaviour
{
    [Header("general")]
    public TMP_Text ScoreText;
    
    [Header("end")]
    public GameObject GameUI;
    public GameObject EndGameUI;
    public GameObject VictoryUI;
    public GameObject LostUI;

    public Button GoToMainMenuButton;

    private void Start()
    {
        GoToMainMenuButton.onClick.AddListener(GTMMBOC);
    }
    
    private void GTMMBOC()
    {
        SceneManager.LoadSceneAsync("MainMenu");
    }
    public void Victory()
    {
        GameUI.SetActive(false);
        EndGameUI.SetActive(true);
        LostUI.SetActive(false);
        VictoryUI.SetActive(true);
    }

    public void Lost()
    {
        GameUI.SetActive(false);
        EndGameUI.SetActive(true);
        VictoryUI.SetActive(false);
        LostUI.SetActive(true);
    }
}