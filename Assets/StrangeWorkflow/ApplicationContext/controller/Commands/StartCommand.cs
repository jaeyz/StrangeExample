using UnityEngine;
using strange.extensions.command.impl;
using strange.extensions.context.api;

public class StartCommand : Command  {


	[Inject(ContextKeys.CONTEXT_VIEW)]
	public GameObject contextView{get;set;}

	[Inject]
	public SceneChangeSignal sceneChangeSignal { get; set; }

	public override void Execute()
	{
		//Add the scene switcher utility.
		GameObject go = new GameObject ();
		go.name = "SceneSwitcher";
		go.transform.parent = contextView.transform;
		go.AddComponent<SceneChanger> ();

		//Bootstrapping phase
		//Load player context since we'll need it for all screens.
		//sceneChangeSignal.Dispatch("playerscene",null);
	}
}
