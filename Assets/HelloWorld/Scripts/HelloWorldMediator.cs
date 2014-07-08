using UnityEngine;
using System.Collections;
using strange.extensions.dispatcher.eventdispatcher.api;
using strange.extensions.mediation.impl;

public class HelloWorldMediator : EventMediator {

	[Inject]
	public HelloWorldView helloWorldView { get; set; }

	[Inject]
	public IPlayer player { get; set; }

	public override void OnRegister() {
		if (helloWorldView != null) {
			Debug.Log ("4. Mediator Registration");
			helloWorldView.signal.AddListener (SayHello);
			helloWorldView.Initialize ();
		}
	}

	public override void OnRemove() {
		helloWorldView.signal.RemoveListener (SayHello);
	}

	void SayHello() {
		Debug.Log ("Hi " + player.PlayerName  + "! So you're role is a " + player.Role + ".");
		Application.LoadLevelAdditive ("");
	}

}
