using System;
using UnityEngine;
using System.Collections.Generic;
using strange.extensions.mediation.impl;


public class MainMenuMediator : Mediator {

	[Inject]
	public MainMenuView view{ get; set;}

	[Inject]
	public MainMenuLoadedSignal mainMenuLoadedSignal { get; set; }

	[Inject]
	public PlayerDataUpdatedSignal playerDataUpdatedSignal { get; set; }

	[Inject]
	public SceneChangeSignal sceneChangeSignal { get; set; }

	string playerName = "jose";
	int playerLevel = 1;

	public override void OnRegister() {
		AddListeners ();
	}

	private void AddListeners() {
		Debug.Log("AddingListeners");
		view.mainMenuLoadedSignal.AddListener(OnLoadMainMenu);
		view.onStartClicked.AddListener (SwitchScene);
		playerDataUpdatedSignal.AddListener(UpdatePlayerDataDisplay);
	}

	public override void OnRemove () {
		view.mainMenuLoadedSignal.RemoveListener(OnLoadMainMenu);
		view.onStartClicked.RemoveListener (SwitchScene);
		playerDataUpdatedSignal.RemoveListener(UpdatePlayerDataDisplay);
	}

	public void OnLoadMainMenu(){
		mainMenuLoadedSignal.Dispatch(view,playerName,playerLevel);
	}

	void UpdatePlayerDataDisplay(){
		//UpdatePlayerDisplay
	}

	private void SwitchScene() {
		sceneChangeSignal.Dispatch ("playerscene", view.gameObject);
	}

}