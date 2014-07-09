using UnityEngine;
using strange.extensions.command.impl;
using strange.extensions.context.api;

public class StartCommand : Command  {


	[Inject(ContextKeys.CONTEXT_VIEW)]
	public GameObject contextView{get;set;}

	public override void Execute()
	{
		Debug.Log ("StartCommand.Execute()");
		//We can initialize and pre load some stuff here and add a loading screen

//		//ADD THE VIEW TO THE HIERARCHY
		GameObject go = new GameObject();
		go.name = "MainMenuView";
		go.AddComponent<MainMenuView>();
		go.transform.parent = contextView.transform;

	}
}
