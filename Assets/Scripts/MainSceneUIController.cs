using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainSceneUIController : MonoBehaviour
{

    [SerializeField] Button startButton;
    [SerializeField] UnityEvent onChange;
    [SerializeField] TMP_InputField inputName;

    public event Action onClick;


    // Start is called before the first frame update
    void Start()
    {
        startButton.onClick.AddListener(OnClickButton);        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }

    public void OnClickButton()
    {
        SceneManager.LoadScene("MazeScene");        
        PlayerPrefs.SetString("player_name", inputName.text);
    }

}
