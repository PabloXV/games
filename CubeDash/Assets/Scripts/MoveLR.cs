using UnityEngine;
using System.Collections;

public class MoveLR : MonoBehaviour {

	public GameObject scoreText;
	private Rigidbody playerRB;
	public float moveSpeed;
	private bool alive = true;
	public float offset = .55f;
	// Use this for initialization
	void Start () {
		playerRB = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

		//Vector3 moveDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0);
		//Vector3 gyroDirection = new Vector3(Input.gyro.attitude.eulerAngles.normalized.z, 0, 0);

		//Vector3 dir = Vector3.zero;

		/*Quaternion referenceRotation = Quaternion.identity;
		Quaternion deviceRotation = DeviceRotation.Get();
		Quaternion eliminationOfXY = Quaternion.Inverse(Quaternion.FromToRotation(referenceRotation * Vector3.forward, deviceRotation * Vector3.forward));
		Quaternion rotationZ = eliminationOfXY * deviceRotation;
		float roll = rotationZ.eulerAngles.normalized.z;*/

		//if(moveDirection.x != 0){
			//playerRB.AddForce(moveDirection * moveSpeed);
		if(alive && Input.GetMouseButton(0)){
			float mousePos = Input.mousePosition.x/Screen.width - .5f;
			playerRB.AddForce(Vector3.right * mousePos * moveSpeed);
		}
		//}
	}

	void OnCollisionEnter (Collision col){
		if(col.collider.tag == "cube"){
			Time.timeScale = 0.3f;
			Invoke("gameOver", 1f);
			alive = false;
			//playerRB.AddForce(Vector3.up * 1500);
			InvokeRepeating("toggleScore", 0f, 0.1f);
		}
	}

	void toggleScore(){
		scoreText.gameObject.SetActive(!(scoreText.gameObject.activeInHierarchy));
	}

	void gameOver (){
		Time.timeScale = 1.0f;
		Application.LoadLevel(0);
	}


}
