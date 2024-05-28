using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.UI;


public class GameOverSceneUIController : MonoBehaviour
{

    [SerializeField] Button startButton;
    [SerializeField] UnityEvent onChange;
    [SerializeField] TMP_InputField inputName;
    [SerializeField] TMP_Text playerName;

    public event Action onClick;       

    void Start()
    {
        playerName.text = PlayerPrefs.GetString(playerName.text);
        startButton.onClick.AddListener(OnClickButton);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }

    public void OnClickButton()
    {
        SceneManager.LoadScene("LetsGoScene");        
    }

}
