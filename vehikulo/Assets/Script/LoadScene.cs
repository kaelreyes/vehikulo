using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScene : MonoBehaviour {

	// Use this for initialization
	public GameObject canvasAbout;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void LoadLevel (int a) {

		Application.LoadLevel (a);
	}

	public void AboutShow(){

			canvasAbout.SetActive(true);
	}

	public void AboutHide(){
		
			canvasAbout.SetActive(false);

	}

}
