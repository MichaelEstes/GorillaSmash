using UnityEngine;
using System.Collections;

public class RightArm : GorillaArm {

	public LeftArm leftArm;

	void Start () {
		base.BaseStart ();
	}
	
	void Update () {
		base.BaseUpdate ();
		if(collided && leftArm.movement){
			//DropArm();
		}
	}

	void DropArm(){
		this.rigidbody2D.isKinematic = false;
	}

//	public override void SetColliding(bool getCollided){
//		collided = getCollided;
//	}
}
