using UnityEngine;
using System.Collections;

public class enemyscrip : MonoBehaviour {

	private Rigidbody cubeRB;

	// Use this for initialization
	void Start(){
		cubeRB = GetComponent<Rigidbody>();
		Destroy(this.gameObject, 10f);
	}

	void Wind () {
		cubeRB.AddTorque(Vector3.forward);
		cubeRB.AddForce(Vector3.back);
	}
	
	// Update is called once per frame
	void Update () {
		InvokeRepeating("Wind", 0f, 0.2f);
	}
}
