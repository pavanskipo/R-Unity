using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour {

    [SerializeField] Text textField;
    [SerializeField] State startingState;

    State state;

	// Use this for initialization
	void Start () {
        state = startingState;
        textField.text = state.getStateStory();
	}
	
	// Update is called once per frame
	void Update () {
        manageState();
	}

    private void manageState() {
        var nextStates = state.getNextStates();
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            state = nextStates[0];
        } else if (Input.GetKeyDown(KeyCode.Alpha2)) {
            state = nextStates[1];
        } else if (Input.GetKeyDown(KeyCode.Alpha3)) {
            state = nextStates[2];
        }

        textField.text = state.getStateStory();

    }
}
