﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Story_attic : MonoBehaviour {

	public Text output;

	float text_timeLeft = 2.0f;

	private int attic_storyCount = 0;

	private string[] outputTips = 
	{
		"Find and use a matchbox to be able to see",
	};

	// Use this for initialization
	void Start () {
		output.text = outputTips[attic_storyCount];
	}
	
	// Update is called once per frame
	void Update () {

		text_timeLeft -= Time.deltaTime;
		if(text_timeLeft < 0)
		{
			//turn off text
			//canvas.enabled = false;
			
			
		}
	}

	private IEnumerator Wait(int value) // 2 second delay on the mouse press
	{
		yield return new WaitForSeconds(1.0f);
		output.text = outputTips [value];
	}
}
