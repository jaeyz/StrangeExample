using UnityEngine;
using System.Collections;
using strange.extensions.context.impl;

public class ApplicationRoot : ContextView {

	void Awake ()
	{
		NGUIDebug.Log("Application Context Loaded");
		context = new ApplicationContext(this,false);
		context.Start();
	}
}
