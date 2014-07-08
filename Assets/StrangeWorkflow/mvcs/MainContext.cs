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
		Debug.Log("Dispatching Signal");
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
//			commandBinder.Bind<StartSignal>().To<StartCommand>().Once ();
//			commandBinder.Bind<AllViewsInitializedSignal>().To<AllViewsInitializedCommand>().Once ();
//			//
//			commandBinder.Bind<CustomServiceLoadedSignal>().To<CustomServiceLoadedCommand>();
//			commandBinder.Bind<ClearButtonClickSignal>().To<ClearButtonClickCommand>();
//			commandBinder.Bind<LoadButtonClickSignal>().To<LoadButtonClickCommand>();
//
//
//
//			//	CONTROLLER 2. (INJECTED SIGNALS)
//			injectionBinder.Bind<GameListUpdatedSignal>().ToSingleton();
//
//			//	SERVICE
//			injectionBinder.Bind<IService>().To<CustomService>().ToSingleton();

	}
}
