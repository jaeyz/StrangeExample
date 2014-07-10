using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;
using strange.extensions.signal.impl;

public class QuitView : View {

	[SerializeField]
	private CustomButton confirmButton;

	[SerializeField]
	private CustomButton cancelButton;

	public Signal OnConfirm;
	public Signal OnCancel;

	public QuitView () {
		OnConfirm = new Signal ();
		OnCancel = new Signal ();
	}

	protected override void Start() {
		AddListeners ();
	}

	protected override void OnDestroy() {
		RemoveListeners ();
	}

	private void AddListeners() {
		confirmButton.buttonClicked += Confirm;
		cancelButton.buttonClicked += Cancel;
	}

	private void RemoveListeners() {
		confirmButton.buttonClicked -= Confirm;
		cancelButton.buttonClicked -= Cancel;
	}

	private void Confirm() {
		if (OnConfirm != null)
			OnCancel.Dispatch ();
	}

	private void Cancel() {
		if (OnCancel != null)
			OnCancel.Dispatch ();
	}
}
