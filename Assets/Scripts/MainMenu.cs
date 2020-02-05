using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class MainMenu : MonoBehaviour
    {
        public Button StartButton;
        public Button QuitButton;

        private void Start()
        {
            StartButton.onClick.AddListener(StartButtonClicked);
            QuitButton.onClick.AddListener(QuitButtonClicked);
        }

        private void StartButtonClicked()
        {
            SceneManager.LoadSceneAsync("MainScene");
        }

        private void QuitButtonClicked()
        {
#if UNITY_EDITOR
            EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
        }
    }
}