using System.Collections.Generic;
using UnityEngine;
using strange.extensions.mediation.impl;
using strange.extensions.signal.impl;

public class MainMenuTestView : View
{
		
	public Signal loadMessageClickSignal;

	public MainMenuTestView()
	{
		//Debug.Log ("CustomViewUI.constructor()");
		loadMessageClickSignal	 = new Signal();

	}

	override protected void Start ()
	{
			//
			base.Start ();
			Debug.Log("Main View Test Start");
			loadMessageClickSignal.Dispatch();
	}
}	