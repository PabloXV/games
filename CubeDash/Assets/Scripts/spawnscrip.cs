using UnityEngine;
using System.Collections;

public class spawnscrip : MonoBehaviour {

	public float spawnTime = 10.0f;
	public float ddx;
	public GameObject cube;
	
	void spawnCube () {
		Instantiate(cube, transform.position, transform.rotation);
	}
	void decrement () {
		spawnTime /= 1.1f;
	}
	
	// Update is called once per frame
	void Start () {
		InvokeRepeating("spawnCube", 1.0f, spawnTime);
		InvokeRepeating("decrement", 0f, ddx);

	}
}
