﻿using UnityEngine;
using System.Collections;

public class puzzle2Key : MonoBehaviour {
	
	private bool withinRadius;
	public GameObject key;
	public static bool pickedup = false;
	
	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)
		   && withinRadius && pickedup == false)
		{
			//Destroy(gameObject);
			key.SetActive(false);
			//gameObject.GetComponent<ParticleSystem>().enableEmission = false;
			pickedup = true;

			print("The key should be picked up");
		}
	}
	
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
			withinRadius = true;
	}
	
	void OnTriggerExit(Collider other)
	{
		if(other.gameObject.tag == "Player")
			withinRadius = false;
	}
}


