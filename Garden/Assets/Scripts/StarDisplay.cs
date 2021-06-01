﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StarDisplay : MonoBehaviour
{
    [SerializeField] int stars = 100;
    Text starText;

    private void Awake()
    {
        starText = GetComponent<Text>();
    }

    private void Start()
    {
        UpdateDisplay();
    }
    private void UpdateDisplay()
    {

        starText.text = stars.ToString();
    }
    public void AddStars(int amount)
    {
        stars += amount;
        UpdateDisplay();
    }
    public void SpendStars(int amount)
    {
        if (stars >= amount)
        {
            stars -= amount;
            UpdateDisplay();
        }
        
    }
    public bool HaveEnoughStars(int starCost)
    {
        return stars >= starCost;
        
    }

}
