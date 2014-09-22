using UnityEngine;
using System.Collections;

public class HangingScript : MonoBehaviour {


	
	void OnTriggerEnter2D(Collider2D collider){
		if(collider.tag == "GorillaHand"){
			collider.GetComponent<GorillaArm>().SetColliding(true);
		}
	}

	void OnTriggerExit2D(Collider2D collider){
		if(collider.tag == "GorillaHand"){
			collider.GetComponent<GorillaArm>().SetColliding(false);
		}
	}
}
