using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.VR;
using GoogleVR;

public class VRDisable : MonoBehaviour {
	void Start () {
		StartCoroutine(SwitchOffVR("None", false));
	}
	void Update () {
		StartCoroutine(SwitchOffVR("None", false));
	}

private	IEnumerator SwitchOffVR(string device, bool vrEnabled) {
		yield return null;
		XRSettings.LoadDeviceByName (device);
		yield return null;
		XRSettings.enabled = vrEnabled;
	}
}
