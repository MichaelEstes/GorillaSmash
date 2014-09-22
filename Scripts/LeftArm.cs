using UnityEngine;
using System.Collections;

public class LeftArm : GorillaArm {

	public RightArm rightArm;

	void Start () {
		base.BaseStart ();
	}
	
	void Update () {
		base.BaseUpdate ();
		if(collided && rightArm.movement){
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
