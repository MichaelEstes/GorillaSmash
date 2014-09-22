using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	public int score;
	public TextMesh scoreText;

	void Start () {
		scoreText.renderer.sortingLayerName = "UI";
		SetText ();
	}
	
	void Update () {
	
	}

	void SetText(){
		scoreText.text = score.ToString ();
	}

	public void AddScore(){
		++score;
		SetText ();
	}
}
