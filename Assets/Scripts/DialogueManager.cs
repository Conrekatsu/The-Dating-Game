﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

    public StateManager stateManager;

    public Text guyDialogue;
    public Text girlDialogue;

    public Text option1;
    public Text option2;
    public Text option3;
    public Text option4;
    public Text option5;
    public Text option6;

    private List<Text> optionTextBoxes = null;

    void Start() {
        optionTextBoxes = new List<Text>();
        optionTextBoxes.Add(option1);
        optionTextBoxes.Add(option2);
        optionTextBoxes.Add(option3);
        optionTextBoxes.Add(option4);
        optionTextBoxes.Add(option5);
        optionTextBoxes.Add(option6);
    }

    void Update() {
        
    }

    public void noKnowledgeEnd() {
        guyDialogue.text = "Um... uh...";

        stateManager.endGame();
    }

    public void populateOptions(List<string> options) {
        for (int i = 0; i < options.Count; ++i) {
            Text box = optionTextBoxes[i];
            box.text = options[i];
        }
    }
}
