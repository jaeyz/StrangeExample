using System;
using UnityEngine;
using strange.extensions.command.api;
using strange.extensions.command.impl;
using strange.extensions.context.api;
using strange.extensions.context.impl;


public class ApplicationContext : MVCSContext {

	public ApplicationContext () : base()
	{
	}

	public ApplicationContext (MonoBehaviour view, bool autoStartup) : base(view, autoStartup)
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
		StartSignal startSignal = (StartSignal)injectionBinder.GetInstance<StartSignal>();
		startSignal.Dispatch();

		return this;
	}

	protected override void mapBindings()
	{
			injectionBinder.Bind<PlayerDataUpdatedSignal>().ToSingleton();
			injectionBinder.Bind<IPlayerModel>().To<PlayerDataModel>().ToSingleton();
			injectionBinder.Bind<SceneChangeSignal>().CrossContext().ToSingleton();

			mediationBinder.Bind<MainMenuView>().To<MainMenuMediator>();

			commandBinder.Bind<MainMenuLoadedSignal>().To<MainMenuLoadedCommand>();
			commandBinder.Bind<SceneChangeSignal>().To<SceneChangeCommand>();
			commandBinder.Bind<StartSignal>().To<StartCommand>().Once ();


	}
}
