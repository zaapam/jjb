using UnityEngine;
using System.Collections;

public class BirdManagerScript : MonoBehaviour {

	public Transform prefabBird;
	private float time = 0;

	// Use this for initialization
	void Start () {
		Transform bird = Instantiate(prefabBird) as Transform;
		bird.parent = transform;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
