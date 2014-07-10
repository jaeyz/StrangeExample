using System;
using UnityEngine;
using strange.extensions.command.api;
using strange.extensions.command.impl;
using strange.extensions.context.api;
using strange.extensions.context.impl;


public class MainContext : MVCSContext {

	public MainContext () : base()
	{
	}

	public MainContext (MonoBehaviour view, bool autoStartup) : base(view, autoStartup)
	{
		Debug.Log ("MainContext.constructor()");
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
			//	MODEL
//			injectionBinder.Bind<ICustomModel>().To<CustomModel>().ToSingleton();
//
//			//	VIEW
//			mediationBinder.Bind<CustomViewUI>().To<CustomViewUIMediator>();
//
//			//	CONTROLLER 1. (MAPPED COMMANDS) 

			injectionBinder.Bind<IPlayerModel>().To<PlayerDataModel>().ToSingleton();
			mediationBinder.Bind<MainMenuView>().To<MainMenuMediator>();
			mediationBinder.Bind<MainMenuTestView>().To<MainMenuMediator>();
			commandBinder.Bind<StartSignal>().To<StartCommand>().Once ();
			commandBinder.Bind<MainMenuLoadedSignal>().To<MainMenuLoadedCommand>();

			injectionBinder.Bind<PlayerDataUpdatedSignal>().ToSingleton();
//			commandBinder.Bind<AllViewsInitializedSignal>().To<AllViewsInitializedCommand>().Once ();
//			//
//			commandBinder.Bind<CustomServiceLoadedSignal>().To<CustomServiceLoadedCommand>();
//			commandBinder.Bind<ClearButtonClickSignal>().To<ClearButtonClickCommand>();
//			commandBinder.Bind<LoadButtonClickSignal>().To<LoadButtonClickCommand>();
//
//
//

//
//			//	SERVICE
//			injectionBinder.Bind<IService>().To<CustomService>().ToSingleton();
	}
}
