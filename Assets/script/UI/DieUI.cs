using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DieUI : MonoBehaviour
{
    public static DieUI Instance { get; private set; }
    
    [SerializeField] private Button ReStartButton;
    [SerializeField] private Button MainMenuButton;
    [SerializeField] private TextMeshProUGUI SurvivalTImeText;
    [SerializeField] private TextMeshProUGUI itemIndexText;

    private void Awake()
    {
        Instance = this;
        
        ReStartButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Map");
        });
        MainMenuButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("MainMenu");
        });
        Hide();
    }

    private void Update()
    {
        SurvivalTImeText.text = $"생존 시간 :{(int)playTime.Instance.playTimes/60}:{(int)playTime.Instance.playTimes%60}";
    }

    public void Show()
    {
        gameObject.SetActive(true);
        pauseUI.Instance.pauseUIpasue = true;
    }

    public void Hide()
    {
        pauseUI.Instance.pauseUIpasue = true;
        gameObject.SetActive(false);
    }
}
