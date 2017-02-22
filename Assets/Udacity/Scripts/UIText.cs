using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIText : MonoBehaviour {

	public Coin coin;
	public Key key;
	[HideInInspector] public int coinCount;
	[HideInInspector] public bool hasKey;
	public Text uiText;

	// Use this for initialization
	void Start () {
		coinCount = 0;
		hasKey = false;
		setText ();
	}
	
	// Update is called once per frame
	void Update () {
		setText ();
	}

	void setText(){
		uiText.text = "Coins: " + coinCount.ToString () + "\n" + "Has Key: " + hasKey.ToString () + 
			"\nTime: " + Time.time.ToString ();

	}
}
