using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class setForeground : MonoBehaviour {
	
	public Image foreground;

	void Awake(){
		foreground.gameObject.SetActive(true);
	}

}
