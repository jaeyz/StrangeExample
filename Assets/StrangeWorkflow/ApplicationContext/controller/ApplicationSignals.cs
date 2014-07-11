using UnityEngine;
using System.Collections;
using strange.extensions.signal.impl;

public class StartSignal : Signal {}

public class SceneChangeSignal : Signal<string, GameObject> {}

public class PlayerDataUpdatedSignal : Signal {}

public class MainMenuLoadedSignal : Signal<MonoBehaviour, string, int> {}
