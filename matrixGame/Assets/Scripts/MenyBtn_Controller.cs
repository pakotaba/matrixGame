using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MenyBtn_Controller : MonoBehaviour {
	public GameObject gameoverpanel;


    public void StartGame()
    {
        Application.LoadLevel("Game");
    }

	public void registrationMatrix()
	{
		//Application.OpenURL("http://www.mindtech.ge/" , '_blank');
		Application.OpenURL("http://www.mindtech.ge/");
		//Application.ExternalEval("window.open('http://www.mindtech.ge/','Registration')");
	}


   
}
