using UnityEngine;
using System.Collections;

public class dontDestroy : MonoBehaviour {
	public static int counter = 0;
	void Awake() {
		if(transform.gameObject.activeInHierarchy == true && counter != 0){
			Destroy (transform.gameObject);
		}
		DontDestroyOnLoad(transform.gameObject);
		counter++;
		
	}
}
