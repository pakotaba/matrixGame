using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreTextScript : MonoBehaviour {

	void Start () {
	}
	
	
	void Update () {

		gameObject.GetComponent<Text>().text = "ქულა: " +  GlobalParams.Score.ToString();
	
	}
}
