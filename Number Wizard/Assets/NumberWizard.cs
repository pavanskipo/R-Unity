﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    int max, min, guess;

    // Use this for initialization
    void Start () {
        StartGame(); 
    }
	
    void StartGame() {
        max = 1000;
        min = 1;
        guess = 500;
        Debug.Log("Welcome to number wizard, yo");
        Debug.Log("Pick a number");
        Debug.Log("Highest number is : " + max);
        Debug.Log("Lowest number is : " + min);
        Debug.Log("Tell me if higher or lower " + guess);
        max += 1;
    }

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return)) {
            Debug.Log("Yay!!!");
            StartGame();
        }

    }

    void NextGuess() {
        guess = (max + min) / 2;
        Debug.Log("Is it higher or lower than : " + guess);
    }
}
