using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class SeenRotate: MonoBehaviour,
ITrackableEventHandler
{
	bool visible = false;
	string name = "Top";
	string name2 = "Second";
	string name3 = "First";
	string name4 = "Walls";
	string name5 = "House";
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
		if (newStatus == TrackableBehaviour.Status.DETECTED ||
			newStatus == TrackableBehaviour.Status.TRACKED ||
			newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
		{
			visible = true;
			}
			else
			{
				visible = false;
			}
}
	// Update is called once per frame
	void Update () {
		if(visible == true) {
			
			//GameObject go = GameObject.Find (name);
			//GameObject go2 = GameObject.Find (name2);
			//GameObject go3 = GameObject.Find (name3);
			//GameObject go4 = GameObject.Find (name4);
			GameObject go5 = GameObject.Find (name5);
			//go.gameObject.transform.RotateAround (go5.transform.position, Vector3.forward * (Time.deltaTime * 36));
			//go2.gameObject.transform.RotateAround (go5.transform.position, Vector3.forward * (Time.deltaTime * 36));
			//go3.gameObject.transform.RotateAround (go5.transform.position, Vector3.forward * (Time.deltaTime * 36));
			//go4.gameObject.transform.RotateAround (go5.transform.position, Vector3.forward * (Time.deltaTime * 36));
			go5.gameObject.transform.Rotate (Vector3.up * (Time.deltaTime * 36));
		}
	}
}