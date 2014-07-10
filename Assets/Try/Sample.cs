using UnityEngine;
using System.Collections;

public class Sample : MonoBehaviour {

	public GameObject pInstance;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.KeypadEnter)) {
			Application.LoadLevelAdditive ("HelloWorldMain");
		}
	}
}
