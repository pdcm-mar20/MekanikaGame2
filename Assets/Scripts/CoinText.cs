﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CoinText : MonoBehaviour
{
    Text scoreText;
    public static int score;
    void Start()
    {
        score = 0;
        scoreText = GetComponent<Text>();    
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Coin : " + score.ToString();
    }
}
