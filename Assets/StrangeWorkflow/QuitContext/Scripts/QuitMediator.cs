using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;

public class QuitMediator : EventMediator {

	[Inject]
	public QuitView quitView { get; set; }

	public override void OnRegister() {
		AddListeners ();
	}
	
	public override void OnRemove() {
		RemoveListeners ();
	}

	private void AddListeners() {
		quitView.OnConfirm.AddListener(Confirm);
		quitView.OnCancel.AddListener(Cancel);
	}

	private void RemoveListeners() {
		quitView.OnConfirm.RemoveListener(Confirm);
		quitView.OnCancel.RemoveListener(Cancel);
	}

	private void Confirm() {
		Debug.Log ("Confirmed Quit!");
	}

	private void Cancel() {
		SceneChanger.Instance.SwitchScene ("ApplicationScene", quitView.gameObject);
	}
}
