using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelSceneUIController : MonoBehaviour
{

    [SerializeField] TMP_Text playerName;
    [SerializeField] HPComponent hpComponent;
    [SerializeField] TMP_Text scoreText;

    public static LevelSceneUIController Instance;

    private int scoreCount = 0;

    public int ScoreCount
    {
        get { return scoreCount; }
        set 
        { 
            scoreCount = value; 
            scoreText.text = $"Moedas: {scoreCount}";
        }
    }

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        playerName.text = PlayerPrefs.GetString(playerName.text);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }

    public void TakeDamage(float damage)
    {
        hpComponent.TakeDamage(damage);
    }

    public void RecoverLife(float count) 
    {
        hpComponent.RecoverLife(count);
    }  

}
