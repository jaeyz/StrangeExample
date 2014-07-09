using System;
using UnityEngine;
using System.Collections.Generic;
using strange.extensions.mediation.impl;


public class MainMenuMediator : Mediator
{

		[Inject]
		public MainMenuView view{ get; set;}

		[Inject]
		public MainMenuLoadedSignal mainMenuLoadedSignal { get; set; }

		int randomData = 5;

		public override void OnRegister()
		{
			//
			Debug.Log("AddingListeners");
			view.loadMessageClickSignal.AddListener(OnLoadMainMenu);
//			allViewsInitializedSignal.Dispatch ();

		}

		public override void OnRemove ()
		{
			view.loadMessageClickSignal.RemoveListener(OnLoadMainMenu);

		}
		public void OnLoadMainMenu(){
			mainMenuLoadedSignal.Dispatch(view,randomData);

		}

}