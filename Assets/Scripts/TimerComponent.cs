using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimerComponent : MonoBehaviour
{

    [SerializeField] TMP_Text timerText;

    public static TimerComponent Instance;

    float startTime;
    float gameTime = 120f;
    float timer = 0;
    float damage = 0;
    int timeHit = 10;

    // Start is called before the first frame update
    void Start()
    {
        timerText.text = "00:00";
    }

    private void Awake()
    {
        startTime = Time.time;
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {        
        timerText.text = ConvertSecondsToTime(Time.time - startTime);        
    }

    string ConvertSecondsToTime(float elapsedTime)
    {       
        int minutes = (int)((gameTime - elapsedTime) / 60) % 60;
        int seconds = (int)((gameTime - elapsedTime) % 60);
        string gameTimerString = string.Format("{0:0}:{1:00}", minutes, seconds);

        timer += Time.deltaTime;

        damage = 100 / (gameTime / timeHit);

        if(timer >= timeHit)
        {
            timer -= timeHit;
            LevelSceneUIController.Instance.TakeDamage(damage);            
        }

        // Times up
        if (elapsedTime >= gameTime)
        {            
            DestroyWithTag("Player1");                     
            SceneManager.LoadScene("GameOverScene");

        }

        return gameTimerString;

    }

    void DestroyWithTag(string destroyTag)
    {
        GameObject[] destroyObject;
        destroyObject = GameObject.FindGameObjectsWithTag(destroyTag);
        foreach (GameObject oneObject in destroyObject)
            Destroy(oneObject);
    }
    public int GetTimeHit()
    {
        return timeHit;
    }

    public void AddTime(float time)
    {
        startTime += time;
    }



}
