using UnityEngine;
using System.Collections;

public class instantMusic : MonoBehaviour {

	public GameObject music;

	// Use this for initialization
	void Start () {
		Instantiate(music);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
