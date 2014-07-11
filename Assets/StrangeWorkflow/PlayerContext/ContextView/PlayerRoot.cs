using UnityEngine;
using System.Collections;
using strange.extensions.context.impl;

public class PlayerRoot : ContextView {

	void Awake ()
	{
		NGUIDebug.Log("Player Context Loaded");
		context = new PlayerContext(this,false);
		context.Start();
	}
}
