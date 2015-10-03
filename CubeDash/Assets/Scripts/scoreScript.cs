using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class scoreScript : MonoBehaviour {

	public Text storyText;
	public Text scoreText;
	public Text hText;
	private float curScore;
	private bool justDied;
	//private int storyCounter = 1;
	public float highscore;

	// Use this for initialization
	void Start () {

		try{
			highscore = PlayerPrefs.GetFloat("hi");
		}
		catch{
			PlayerPrefs.SetFloat("hi", 0.0f);highscore = PlayerPrefs.GetFloat("hi1");
		}

		hText.text = (int)highscore/10 + "." + (int)highscore%10;

	}
	
	// Update is called once per frame
	void Update () {
		if(Time.timeScale == 1f){
			scoreText.text = "" + (int)curScore/10 + "." + (int)curScore%10;// + "/" + (int)highScore/10 + "." + (int)highScore%10;
			curScore += Time.deltaTime*10;

			//if(curScore > storyCounter * 60){
				//toggleStory(storyCounter);
				//storyCounter++;
			//}
		}
		else{
			if(curScore > highscore){
				highscore = curScore;
			}
		}

		hText.text = (int)highscore/10 + "." + (int)highscore%10;

		PlayerPrefs.SetFloat("hi", highscore);
	}

	void toggleStory (int n) {

		string story = "";

		switch(n){
		case 1: story = "hi"; break;
		case 2: story = "i bounce"; break;
		case 3: story = "what do you do?"; break;
		case 4: story = "oh"; break;
		case 5: story = "they left me here"; break;
		case 6: story = "left me to die"; break;
		case 7: story = "good luck"; break;
		default: story = "goodbye"; break;
		}

		storyText.gameObject.GetComponent<Animator>().SetTrigger("toggleStory");
		storyText.text = story;
		//Invoke("toggleStoryHelper", 4.0f);
	}



}
