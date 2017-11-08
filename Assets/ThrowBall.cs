using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowBall : MonoBehaviour {

	public GameObject pokemonBallPrefab;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			GameObject ball = Instantiate(pokemonBallPrefab, Camera.main.transform.position, Camera.main.transform.rotation);
			ball.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward*500);
		}
	}
}