using UnityEngine;
using System.Collections;

public class MoveEnemy : MonoBehaviour {


	float spearZ = 0;
	float score = 0;
	bool spearChange;
	
	int speedForward = 2;
	
	Vector3 touchStart;

	public GameObject spear;




	// Use this for initialization
	void Start () {

		spearChange =false;

	
	}
	
	// Update is called once per frame
	void Update () {

		MoveHuman();

	
	}//update


	void MoveHuman(){


		Vector3 moveDir = new Vector3 (speedForward, 0, 0);

		transform.Translate (moveDir * Time.smoothDeltaTime);
	}//move







		


}
