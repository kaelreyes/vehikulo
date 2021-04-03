using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class StartProcess : MonoBehaviour {

	public GameObject StartPage;
	public GameObject Menu;
	public GameObject Quiz;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void onlickStart(){
		Menu.SetActive(true);
		StartPage.SetActive(false);
	}

	public void onclickBack(){
		if (StartPage.active == false && Menu.active == false){
			Menu.SetActive(true);
			Quiz.SetActive(false);
		}
		else if (StartPage.active == false){
			StartPage.SetActive(true);
			Menu.SetActive(false);
		}

		
	}

	public void onclickQuestionaire(){
		Quiz.SetActive(true);
		Menu.SetActive(false);
	}
}
