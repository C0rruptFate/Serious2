using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controls : MonoBehaviour {

    public Slider energy;

    public Button inflammatoryHeadlineButton;
    public int inflammatoryHeadlineCost;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void InflammatoryHeadlines(Text Headline)
    {
        Headline.text = "Comey is an Idiot who eats unbaptised babies!";
        energy.value = energy.value - inflammatoryHeadlineCost;

        //Disable button
        inflammatoryHeadlineButton.interactable = false;
    }

    void checkToDisableButtons()
    {

    }
}
