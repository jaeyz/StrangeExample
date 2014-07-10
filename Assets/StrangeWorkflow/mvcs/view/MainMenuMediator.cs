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

		[Inject]
		public PlayerDataUpdatedSignal playerDataUpdatedSignal { get; set; }

		string playerName = "jose";

		public override void OnRegister()
		{
			Debug.Log("AddingListeners");
			view.loadMessageClickSignal.AddListener(OnLoadMainMenu);
			playerDataUpdatedSignal.AddListener(UpdatePlayerDataDisplay);

		}

		public override void OnRemove ()
		{
			view.loadMessageClickSignal.RemoveListener(OnLoadMainMenu);

		}
		public void OnLoadMainMenu(){
			mainMenuLoadedSignal.Dispatch(view,playerName);

		}

		void UpdatePlayerDataDisplay(){
			Debug.Log("Updating Player Data Display");

		}

}