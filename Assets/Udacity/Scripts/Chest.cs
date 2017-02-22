using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour {

	public GameObject chestTop;
	[HideInInspector] public bool chestClicked;
	public GameObject signPost;

	void Start(){
		chestClicked = false;
	}

	// Update is called once per frame
	void Update () {
		if (chestClicked == true) {
			if (chestTop.transform.rotation.x < 0) {
				chestTop.transform.Rotate (30 * Time.deltaTime, 0, 0);
			} else {
				signPost.SetActive(true);
				chestClicked = false;
			}
		}
	}

	public void OnChestClicked(){
		chestClicked = true;
	}
}
