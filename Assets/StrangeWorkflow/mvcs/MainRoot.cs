using UnityEngine;
using System.Collections;
using strange.extensions.context.impl;

public class MainRoot : ContextView {

	void Awake ()
	{
		context = new MainContext(this,true);
		context.Start();
	}
}
