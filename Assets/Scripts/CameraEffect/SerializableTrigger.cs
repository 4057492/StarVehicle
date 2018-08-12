using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class AcitveEvent : UnityEvent<string>
{

}

[System.Serializable]
public class DisacitveEvent : UnityEvent<string>
{

}

public class SerializableTrigger : MonoBehaviour {
	public AcitveEvent activeEvent;
	public DisacitveEvent disactiveEvent;

	void OnTriggerEnter(){
		if (activeEvent != null) {
			activeEvent.Invoke ("");
		}
	}

	void OnTriggerExit(){
		if (disactiveEvent != null) {
			disactiveEvent.Invoke ("");
		}
	}
}
