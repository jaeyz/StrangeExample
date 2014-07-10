using UnityEngine;
using System.Collections;
using strange.extensions.context.impl;
using strange.extensions.context.api;
using strange.extensions.dispatcher.eventdispatcher.impl;
using strange.extensions.dispatcher.eventdispatcher.api;

public class HelloWorldContext : MVCSContext {

	public HelloWorldContext(MonoBehaviour view) : base(view) {}

	protected override void mapBindings() {

		Debug.Log ("2. Executing Map Bindings");

		injectionBinder.Bind<IPlayer> ().To<PlayerDataModel> ().ToSingleton();
		mediationBinder.Bind<HelloWorldView> ().To<HelloWorldMediator> ();
		commandBinder.Bind (ContextEvent.START).To<HelloWorldCommand> ().Once ();

	}


}
