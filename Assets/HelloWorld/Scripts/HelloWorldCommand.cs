using UnityEngine;
using System.Collections;
using strange.extensions.context.api;
using strange.extensions.command.impl;
using strange.extensions.command.api;
using strange.extensions.dispatcher.eventdispatcher.impl;

public class HelloWorldCommand : EventCommand {

	[Inject]
	public IPlayer player { get; set; }

	[Inject(ContextKeys.CONTEXT_VIEW)]
	public GameObject v { get; set; }

	public override void Execute() {

		Debug.Log("3. Executing the first command and setting values for our model");

		player.SetPlayerName ("2EZ4JZ");
		player.SetRole ("Solo Mid");

		Debug.Log (player.PlayerName + " " + player.Role);

		GameObject g = new GameObject ();
		g.AddComponent<HelloWorldView> ();
		g.transform.parent = v.transform;

	}


}
