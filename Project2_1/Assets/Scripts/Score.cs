using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
	public static int score;
	Text text;
	// Use this for initialization
	void Awake() {
		text = GetComponent<Text>();
		score = 0;
<<<<<<< HEAD
		text.text = "Score: " + score +" point";
=======
		text.text = "Score: " + score;
>>>>>>> f066e8baabf905e0a9b9f1a9f06007bf603a2262
	}
	// Update is called once per frame

	void Update() {
		text.text = "Score: " + score +" point";
		Debug.Log(text.text	);
	}
}
