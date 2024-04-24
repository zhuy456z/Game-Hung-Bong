﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;    
public class UIManager : MonoBehaviour
{
    public Text ScoreText;
    public GameObject GameOverPanel; 
    public void setScore(string txt)
    {
        ScoreText.text = txt;
    }
    public void ShowGameOverPanel(bool isShow)
    {
        if (GameOverPanel)
        {
            GameOverPanel.SetActive(isShow);
        }
    }
}
