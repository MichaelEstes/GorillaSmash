using UnityEngine;
using System.Collections;

public class GorillaArm : MonoBehaviour {

	public int mouseCount = 0;
	public const int velocityModifier = 10;
	public bool movement;
	public bool collided;
	public Vector3 mouseVelocity;
	public LayerMask mask;
	public Score score;
	public Rigidbody2D gorillaTorso;

	public void BaseStart () {
		gorillaTorso = GameObject.FindGameObjectWithTag ("GorillaTorso").rigidbody2D;
		movement = false;
	}
	
	public void BaseUpdate () {
		
		if(Input.GetMouseButtonDown(0)){
			RaycastHit2D hitInfo = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, 1, mask);
			if(hitInfo.collider != null){
				if(hitInfo.collider.name == this.gameObject.name){
					movement = true;
					this.rigidbody2D.isKinematic = false;
				}
			}
		}else if(Input.GetMouseButtonUp(0)){
			movement = false;
			if(collided){
				this.rigidbody2D.isKinematic = true;
				score.AddScore();
				if(mouseCount < 1){
					mouseCount++;
				}else{
					gorillaTorso.isKinematic = false;
				}
			}
		}
		
		if(movement){
			mouseVelocity = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			mouseVelocity -= this.transform.position;
			this.rigidbody2D.gravityScale = 0;
			this.rigidbody2D.velocity = mouseVelocity * velocityModifier;
		}else{
			this.rigidbody2D.gravityScale = 20;
		}
	}
	
	public void SetColliding(bool getCollided){
		collided = getCollided;
	}
	
//	public void DropArm(){
//		this.rigidbody2D.isKinematic = false;
//	}
	
}
