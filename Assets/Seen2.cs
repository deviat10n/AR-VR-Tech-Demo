using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Seen2 : MonoBehaviour,
ITrackableEventHandler
{
	private TrackableBehaviour mTrackableBehaviour;
	// Use this for initialization
	void Start () {
		mTrackableBehaviour = GetComponent<TrackableBehaviour>();
		if (mTrackableBehaviour)
		{
			mTrackableBehaviour.RegisterTrackableEventHandler(this);
		}
	}
	
	public void OnTrackableStateChanged(
		TrackableBehaviour.Status previousStatus,
		TrackableBehaviour.Status newStatus)
	{
		string name = "Top";
		GameObject go = GameObject.Find (name);
		if (newStatus == TrackableBehaviour.Status.DETECTED ||
			newStatus == TrackableBehaviour.Status.TRACKED ||
			newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
		{
			go.gameObject.GetComponent<Renderer> ().enabled = false;
		}
		else
		{
			// Target Lost
			go.gameObject.GetComponent<Renderer> ().enabled = true;
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}