using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour {

	// Use this for initialization
	public static int coinV;
	Text text;
	 void Awake() {
		text = GetComponent<Text>();
		coinV = 300;
		text.text = "Coin:" +coinV;
	}
	// Update is called once per frame
	void Update () {
		text.text = ": "+coinV;
		Debug.Log(text.text);
	}
}
