using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.VR;
using GoogleVR;

public class VREnable : MonoBehaviour {
	void Start () {
		StartCoroutine(SwitchOnVR("cardboard", true));
	}

	private	IEnumerator SwitchOnVR(string device, bool vrEnabled) {
		yield return null;
		XRSettings.LoadDeviceByName (device);
		yield return null;
		XRSettings.enabled = vrEnabled;

	}
}