using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public Question[] questions;

	private static List<Question> unansweredQuestions;

	private Question currentQuestion;

	[SerializeField]
	private Text factText;

	[SerializeField]
	private float timeBetweenQuestions = 1f;

	public GameObject trueAnswerGameObject;
	public GameObject FalseAnswerGameObject;

	public int i = 0;


	void Start () {
		if(unansweredQuestions == null || unansweredQuestions.Count == 0)
		{
			unansweredQuestions = questions.ToList<Question>();
		}
		SetCurrentQuestion();

	}

	void SetCurrentQuestion()
	{
		int randomQuestionIndex = Random.Range(0, unansweredQuestions.Count);
		currentQuestion = unansweredQuestions[randomQuestionIndex];

		factText.text = currentQuestion.fact;

	}

	IEnumerator TransitionToNextQuestion()
	{
		unansweredQuestions.Remove(currentQuestion);
		yield return new WaitForSeconds(timeBetweenQuestions);

		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	public void UserSelectTrue()
	{
		if (currentQuestion.isTrue){
			trueAnswerGameObject.SetActive(true);
			FalseAnswerGameObject.SetActive(false);
			Debug.Log("CORRECT!");
			i++;
			Debug.Log(i);
			
			}else{
			trueAnswerGameObject.SetActive(false);
			FalseAnswerGameObject.SetActive(true);
			Debug.Log("WRONG!");
		}

		StartCoroutine(TransitionToNextQuestion());
	}
	public void UserSelectFalse()
	{
		if (!currentQuestion.isTrue){
			trueAnswerGameObject.SetActive(true);
			FalseAnswerGameObject.SetActive(false);
			Debug.Log("CORRECT!");
			i++;
			Debug.Log(i);

			}else{
			trueAnswerGameObject.SetActive(false);
			FalseAnswerGameObject.SetActive(true);
			Debug.Log("WRONG!");
		}

		StartCoroutine(TransitionToNextQuestion());
	}
}
