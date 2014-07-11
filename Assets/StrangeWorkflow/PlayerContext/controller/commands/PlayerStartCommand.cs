using UnityEngine;
using strange.extensions.command.impl;
using strange.extensions.context.api;

public class PlayerStartCommand : Command  {


	[Inject(ContextKeys.CONTEXT_VIEW)]
	public GameObject contextView{get;set;}

	[Inject]
	public SceneChangeSignal sceneChangeSignal { get; set; }

	public override void Execute()
	{
		GameObject go = new GameObject();
		go.name = "PlayerInfoView";
		go.AddComponent<PlayerInfoView>();
		go.transform.parent = contextView.transform;
	}
}
