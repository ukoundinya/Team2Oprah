﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowMoney : MonoBehaviour {

    public Text moneyText;
    public Text moneyText2;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        moneyText.text = CollectionAndMonster.money.ToString();
        moneyText2.text = CollectionAndMonster.money.ToString();

    }
}
