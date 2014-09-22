using UnityEngine;
using System.Collections;

public class BuildingInstantiate : MonoBehaviour {
	
	public int level = 1;
	public float yPosition;
	public const float yOffSet = 2.56f;
	public BoxCollider2D buildingTrigger;
	public GameObject building;
	public GameObject buildingClone;

	void Start () {
		int levelCount = level * 10;
		buildingTrigger = this.collider2D as BoxCollider2D;
		buildingTrigger.size = new Vector3 (yOffSet, (yOffSet * levelCount) + 2, 0);
		buildingTrigger.center = new Vector2 (0, (yOffSet * levelCount) / 2);
		for(int i = 0; i < 10; ++i){
			yPosition += yOffSet;
			buildingClone = (GameObject)Instantiate(building, new Vector3( 0, yPosition, 0), this.transform.rotation);
		}
	}
	
	void Update () {
	
	}
}
