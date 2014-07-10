using UnityEngine;
using strange.extensions.command.impl;
using strange.extensions.context.api;

public class MainMenuLoadedCommand : Command  
{
	[Inject]
	public MonoBehaviour view {get; set;}

	[Inject]
	public string playerName { get; set; }

	[Inject]
	public IPlayerModel iPlayerModel {get; set;}

	public override void Execute()
	{
		Debug.Log ("Do this stuff here, parameters taken from mainmenuview");
		Debug.Log("Player name changed to" + playerName);
		iPlayerModel.playerName = playerName;
	}
}
