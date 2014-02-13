using UnityEngine;
using System.Collections;

public class BirdScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown () {
		Debug.Log("Force!!!");
		Vector2 force = new Vector2(0, 100);
		Rigidbody2D rigid = GetComponent<Rigidbody2D>();
		//rigid.mass * rigid.acc
		rigid.AddForce(force);
	}
}
