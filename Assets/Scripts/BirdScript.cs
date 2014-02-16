using UnityEngine;
using System.Collections;

public class BirdScript : MonoBehaviour {

	public int minFlySpeed = 20;
	public int maxFlySpeed = 40;

	// Use this for initialization
	void Start () {
		Physics.gravity = new Vector3(0, -4.8f, 0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown () {
		Debug.Log("Force!!!");
		//Vector2 force = new Vector2(0, 100);
		Rigidbody rigid = GetComponent<Rigidbody>();
		//rigid.mass * rigid.acc
		rigid.AddForce(Vector3.up * 20, ForceMode.VelocityChange);
	}
}
