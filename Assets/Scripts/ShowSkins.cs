﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowSkins : MonoBehaviour {

    public GameObject EnergyPanel;
    public GameObject SkinsPanel;
    public GameObject MoneyPanel;

    // Use this for initialization
    void Start()
    {
        //skinsPanel = GameObject.Find("SkinsPanel");
        SkinsPanel.SetActive(false);
    }

    // Update is called once per frame
    public void OnClick()
    {
        EnergyPanel.SetActive(false);
        MoneyPanel.SetActive(false);
        SkinsPanel.SetActive(true);
    }
}
