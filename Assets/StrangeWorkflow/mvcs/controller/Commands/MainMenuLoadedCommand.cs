using UnityEngine;
using strange.extensions.command.impl;
using strange.extensions.context.api;

public class MainMenuLoadedCommand : Command  
{


	[Inject]
	public MonoBehaviour view {get; set;}

	[Inject]
	public int randomData { get; set; }
	public override void Execute()
	{
		Debug.Log ("Do this stuff here, parameters taken from mainmenuview");
		Debug.Log("got this shit from a signal from a view:" + randomData);
	}
}
