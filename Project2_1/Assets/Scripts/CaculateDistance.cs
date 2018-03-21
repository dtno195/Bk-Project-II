using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaculateDistance : MonoBehaviour {

	// Use this for initialization
	public GameObject parking;

	public float Distance_;
	void Start () {
	}
	// Update is called once per frame
	void Update () {
		Distance_ = Vector3.Distance(gameObject.transform.position,parking.transform.position);
		if(Distance_ < 8 ){
			Destroy(gameObject);
			Coin.coinV -= 10;
			
		}
		
	}

	
}
