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
		int playerLevel = 1;

		public override void OnRegister()
		{
			Debug.Log("AddingListeners");
			view.mainMenuLoadedSignal.AddListener(OnLoadMainMenu);
			playerDataUpdatedSignal.AddListener(UpdatePlayerDataDisplay);

		}

		public override void OnRemove ()
		{
			view.mainMenuLoadedSignal.RemoveListener(OnLoadMainMenu);

		}
		public void OnLoadMainMenu(){
			mainMenuLoadedSignal.Dispatch(view,playerName,playerLevel);

		}

		void UpdatePlayerDataDisplay(){
			//UpdatePlayerDisplay
		}

}