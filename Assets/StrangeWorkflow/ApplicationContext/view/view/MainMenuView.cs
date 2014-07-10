using System.Collections.Generic;
using UnityEngine;
using strange.extensions.mediation.impl;
using strange.extensions.signal.impl;

public class MainMenuView : View
{
	[SerializeField]
	private CustomButton startButton;

		
	public Signal mainMenuLoadedSignal;
	public Signal onStartClicked;

	public MainMenuView()
	{
		mainMenuLoadedSignal = new Signal();
		onStartClicked = new Signal ();
	}

	override protected void Start ()
	{
		base.Start ();
		Debug.Log("Main View Start");
		mainMenuLoadedSignal.Dispatch();
		AddListeners ();
	}

	void AddListeners() {
		startButton.buttonClicked += OnStart;
	}

	void RemoveListeners() {
		startButton.buttonClicked -= OnStart;
	}

	protected override void OnDestroy() {
		RemoveListeners ();
	}

	void OnStart() {
		if (onStartClicked != null) {
			startButton.buttonClicked -= OnStart;
			onStartClicked.Dispatch ();
		}
	}
}	