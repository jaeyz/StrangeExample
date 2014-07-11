﻿using UnityEngine;
using strange.extensions.command.impl;
using strange.extensions.context.api;

public class StartCommand : Command  {


	[Inject(ContextKeys.CONTEXT_VIEW)]
	public GameObject contextView{get;set;}

	[Inject]
	public SceneChangeSignal sceneChangeSignal { get; set; }

	public override void Execute()
	{
		//Bootstrapping phase
		//Load player context since we'll need it for all screens.
		//Temporary gameobject to simulate ui destroy
		GameObject go = new GameObject();
		sceneChangeSignal.Dispatch("playerscene",go);
//		sceneChangeSignal.Dispatch("mainmenuscene",go);
	}
}