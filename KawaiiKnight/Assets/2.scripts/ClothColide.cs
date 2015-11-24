using UnityEngine;
using System.Collections;

public class ClothColide : MonoBehaviour {

	void OnTriggerEnter(Collider coll){
		
		Debug.Log("colide enemy");
		
		switch (coll.transform.tag) {
		case "SPEAR":
			
			Debug.Log("colide cloth");
			
			GameObject cloth = GameObject.Find("enemy_cloth");
			
			cloth.SetActive(false);
			
			break;
		}
	}
}
