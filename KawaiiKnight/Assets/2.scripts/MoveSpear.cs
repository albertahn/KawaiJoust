using UnityEngine;
using System.Collections;

public class MoveSpear : MonoBehaviour {


	float spearZ;

	bool spearChange;
	
	int speedForward = 2;
	
	Vector3 touchStart;

	public GameObject spear;




	// Use this for initialization
	void Start () {

		spearChange = false;
		//get the spear

		spearZ = spear.transform.localEulerAngles.z;
	
	}
	
	// Update is called once per frame
	void Update () {

		MoveHuman();


		if(spearChange){

			spear.transform.localEulerAngles = new Vector3(10,0,spearZ);

			//spearChange =false;

		}//changed spear rotation

	
	}//update


	void MoveHuman(){

		if (Application.platform == RuntimePlatform.Android ||
		    Application.platform == RuntimePlatform.IPhonePlayer) {
			CheckMobile();
		} else {
			CheckKeyboard();
		}
		
		Vector3 moveDir = new Vector3 (speedForward, 0, 0);

		transform.Translate (moveDir * Time.smoothDeltaTime);
	}//move



	
	void CheckMobile(){

		float x = Input.acceleration.x;

		
		foreach (Touch tmp in Input.touches) {
			if(tmp.phase == TouchPhase.Began){
				touchStart = tmp.position;
			}
			
			if(tmp.phase == TouchPhase.Moved){
				Vector3 touchEnd = tmp.position;
				
				//아래에서 위로 드래그한경우
				if(touchEnd.y - touchStart.y>50){

					//uplance

					spearZ = spearZ+2.0f;
					spearChange = true;


				}//up the lance

				if(touchEnd.y - touchStart.y<-50){
					


					spearZ = spearZ- 2.0f;
					spearChange = true;


				}//down the lance


			}
			
		}//for each touch
	}//check mobile end



	void CheckKeyboard(){
		float key = Input.GetAxis ("Horizontal");
		

		if (Input.GetKeyDown (KeyCode.UpArrow)) {



			spearZ = spearZ+6.0f;
			spearChange = true;

			Debug.Log("uparrow");
		}//endif

		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			Debug.Log("idownarrow");

			spearZ = spearZ-6.0f;
			spearChange = true;

		}//endif
		
	
	}//check keyboard end




}
