﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadVR1 : MonoBehaviour {
	public Button yourButton;

	void Start () {
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick(){
		SceneManager.LoadScene ("VR1", LoadSceneMode.Single);
	}
}