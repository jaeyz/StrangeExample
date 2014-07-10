using UnityEngine;
using System.Collections;
using strange.extensions.context.impl;

public class ApplicationRoot : ContextView {

	void Awake ()
	{
		context = new ApplicationContext(this,true);
		context.Start();
	}
}
