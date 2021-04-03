using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TFScript : MonoBehaviour {

	public TF[] tf;
	public Text questions;
	public Text totalAnswer;
	public GameObject totalScoreCanvas;

	public int i = 0;
	public	int totalClick = 0;
	public int correctAnswer = 0;
	


	public void trueButton () {

		if(tf[i].isTrue)
		{
			correctAnswer++;
			if(i + 1 < tf.Length)
				{
					i++;
					Debug.Log(i);
				}
		
		}
		else
		{
			if(i + 1 < tf.Length)
				{
					i++;
				}
		}
		totalClick++;
	}

	public void falseButton () {
		if(!tf[i].isTrue)
		{
			correctAnswer++;
			if(i + 1 < tf.Length)
				{
					i++;
					
				}
		
		}
		else
		{
			if(i + 1 < tf.Length)
				{
					i++;
				}
		}
		totalClick++;


	}

	public void LoadLevel (int b) {

		Application.LoadLevel (b);
	}
	
	// Update is called once per frame
	void Update () {
		questions.text = tf[i].questions;
		totalAnswer.text = correctAnswer.ToString();
		if (tf.Length == totalClick)
		{
			totalScoreCanvas.SetActive(true);
		}
	}
}
