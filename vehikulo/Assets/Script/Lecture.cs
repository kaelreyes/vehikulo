using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Lecture {

	public string title;
	
	[TextArea(3, 10)]
	public string body;
}
