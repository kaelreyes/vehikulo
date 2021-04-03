using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialogueManager : MonoBehaviour {

	public Dialogue dialogue;

	public Text dialogueText;

	private Queue<string> sentences;

	void Start () {
		sentences = new Queue<string>();
		StartDialogue(dialogue);
	}

	public void StartDialogue (Dialogue dialogue)
	{

		sentences.Clear();
		
		foreach (string sentence in dialogue.sentences)
		{
			sentences.Enqueue(sentence);
		}

		DisplayNextSentences();
	}

	public void DisplayNextSentences()
	{
		if (sentences.Count == 0)
		{
			EndDialouge();
			return;
		}
		string sentence = sentences.Dequeue();
		dialogueText.text = sentence;
	}





	void EndDialouge()
	{
		Debug.Log("End of Dialogue");
	}
}
