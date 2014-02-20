using UnityEngine;
using System.Collections;

public class BirdScript : MonoBehaviour {

	public int minFlySpeed = 1;
	public int maxFlySpeed = 2;

	// Use this for initialization
	void Start () {
		Physics.gravity = new Vector3(0, -4.8f, 0);
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(GetComponent<Rigidbody>().velocity);
	}

	void OnMouseDown () {

		//Vector2 force = new Vector2(0, 100);
		Rigidbody rigid = GetComponent<Rigidbody>();
		float speed = Random.Range(minFlySpeed, maxFlySpeed);
		/*if (rigid.velocity.y < 0) {
			speed = -rigid.velocity.y + speed;
		} else {
			speed = rigid.velocity.y + speed;
		}*/
		//rigid.mass * rigid.acc
		Debug.Log(speed);
		//rigid.AddForce(Vector3.up * speed, ForceMode.VelocityChange);
		rigid.velocity = Vector3.up * (speed / 10);
	}
}
