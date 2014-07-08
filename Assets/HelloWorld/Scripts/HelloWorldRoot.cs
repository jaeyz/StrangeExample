using UnityEngine;
using System.Collections;
using strange.extensions.context.impl;

public class HelloWorldRoot : ContextView {
	
	void Awake() {
		Debug.Log ("1. Executing root");
		context = new HelloWorldContext	 (this);
	}

}
