using System;
using UnityEngine;
using System.Collections.Generic;
using strange.extensions.mediation.impl;


public class PlayerInfoMediator : Mediator
{
		[Inject]
		public PlayerInfoView view{ get; set;}

		[Inject]
		public SceneChangeSignal sceneChangeSignal {get; set;}

		string playerName = "jose";
		int playerLevel = 1;

		public override void OnRegister()
		{
			view.playerInfoLoaded.AddListener(OnLoadPlayerInfo);
			view.goToMainMenuClicked.AddListener(GoToMainMenu);
		}

		public override void OnRemove ()
		{
			view.playerInfoLoaded.RemoveListener(OnLoadPlayerInfo);
			view.goToMainMenuClicked.RemoveListener(GoToMainMenu);

		}
		public void OnLoadPlayerInfo(){
			view.playerName = playerName;
		}

		public void GoToMainMenu (){
			sceneChangeSignal.Dispatch("mainMenuscene",view.gameObject);
		}

		void UpdatePlayerDataDisplay(){
			//UpdatePlayerDisplay
		}

}