using UnityEngine;
using System.Collections;

public class SceneChanger : MonoBehaviour {

	private static SceneChanger _sharedInstance = null;
	public static SceneChanger Instance {
		get {
			if(_sharedInstance == null)
				_sharedInstance = (SceneChanger)GameObject.FindObjectOfType(typeof(SceneChanger));
			return _sharedInstance;
		}
	}

	public void SwitchScene(string sceneName, GameObject prefab) {
		if (!string.IsNullOrEmpty (sceneName)) {
			Application.LoadLevelAdditive (sceneName);
			Destroy (prefab);
		}
	}

}
