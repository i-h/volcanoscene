using UnityEngine;
using System.Collections;

public class ScoreScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		PlayerScript.score = (int)PlayerScript.lifeTime;
		Screen.showCursor = true;
	}
}
