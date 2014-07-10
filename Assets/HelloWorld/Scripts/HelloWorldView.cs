using UnityEngine;
using System.Collections;
using strange.extensions.dispatcher.eventdispatcher.api;
using strange.extensions.mediation.impl;
using strange.extensions.signal.impl;

public class HelloWorldView : View {

	public Signal signal = new Signal ();

	public void Initialize() {
		Debug.Log ("5. Initializing View.");
	}

	void Update() {
		if (Input.GetKeyUp (KeyCode.KeypadEnter)) {
			//if (signal != null)
			//	signal.Dispatch ();
		}
	}

}
