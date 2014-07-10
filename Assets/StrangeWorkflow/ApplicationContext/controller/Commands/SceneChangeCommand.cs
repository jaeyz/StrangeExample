using UnityEngine;
using strange.extensions.command.impl;
using strange.extensions.context.api;

public class SceneChangeCommand : Command {

	[Inject]
	public string sceneName { get; set; }

	[Inject]
	public GameObject prefab { get; set; }

	public override void Execute ()
	{
		SceneChanger.Instance.SwitchScene(sceneName,prefab);
	}
}
