using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LectureScript : MonoBehaviour {

	public Lecture[] lecture; //store all your images in here at design time
	public Text title; //The current image thats visible
	public Text body; //The current image thats visible
	public GameObject okButton;
	public GameObject nextButton;
	public GameObject previousButton;
	public GameObject backButton;


	public int i = 0; //Will control where in the array you are


	public void NextButton () {
		if(i + 1 < lecture.Length)
		{
			i++;
			previousButton.SetActive(true);
			backButton.SetActive(false);
		}
	}

	public void PreviousButton () {
		if(i - 1 > -1)
		{
			i--;
		}
		if ( i - 1 == -1)
		{
			backButton.SetActive(true);
			previousButton.SetActive(false);
		}
		okButton.SetActive(false);
		nextButton.SetActive(true);
	}
 	
 	public void LoadLevel (int a) {

		Application.LoadLevel (a);
	}
	
	void Update () {
		title.text = lecture[i].title;
		body.text = lecture[i].body;

		if ((lecture.Length - 1) == i)
		{
			okButton.SetActive(true);
			nextButton.SetActive(false);
		}
	}
}
