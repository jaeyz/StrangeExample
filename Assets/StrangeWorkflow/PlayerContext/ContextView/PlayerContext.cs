using UnityEngine;
using System.Collections;
using strange.extensions.command.api;
using strange.extensions.command.impl;
using strange.extensions.context.api;
using strange.extensions.context.impl;

public class PlayerContext : MVCSContext {

	public PlayerContext () : base ()
	{


	}

	public PlayerContext (MonoBehaviour view, bool autoStartup) : base (view, autoStartup)
	{


	}

	protected override void addCoreComponents()
	{
		base.addCoreComponents();
		injectionBinder.Unbind<ICommandBinder>();
		injectionBinder.Bind<ICommandBinder>().To<SignalCommandBinder>().ToSingleton();
	}
	
	override public IContext Start()
	{
		base.Start();
		PlayerStartSignal startSignal = (PlayerStartSignal)injectionBinder.GetInstance<PlayerStartSignal>();
		startSignal.Dispatch();

		return this;
	}

	protected override void mapBindings()
	{
		mediationBinder.Bind<PlayerInfoView>().To<PlayerInfoMediator>();
		commandBinder.Bind<PlayerStartSignal>().To<PlayerStartCommand>().Once ();
	}
}
