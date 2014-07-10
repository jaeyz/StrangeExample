using UnityEngine;
using System.Collections;

public class CustomButton : MonoBehaviour {

	public System.Action buttonClicked;

	void OnClick() {
		if (buttonClicked != null)
			buttonClicked ();
	}
		

}
