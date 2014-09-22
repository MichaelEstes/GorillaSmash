using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	public float yMargin = 0.5f;
	public float smoothTime = 0.1f;
	private Vector3 velocity = Vector3.zero;
	private Transform gorilla;
	
	void Start(){
		gorilla = GameObject.FindGameObjectWithTag ("GorillaTorso").transform;
	}
	
	void Update () {
		Vector3 playerPos = gorilla.position;
		playerPos.z = -10;
		playerPos.x = 0;
		if(gorilla.rigidbody2D.isKinematic){
			playerPos.y += 0.5f;
		}
		if(Mathf.Abs(this.transform.position.y - playerPos.y) > yMargin){
			transform.position = Vector3.SmoothDamp (transform.position, playerPos, ref velocity, smoothTime);
		}
	}
}