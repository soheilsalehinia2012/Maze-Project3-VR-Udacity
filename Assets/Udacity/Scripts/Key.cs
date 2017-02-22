using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
	public GameObject keyPoof;
	public Door door;
	public GameObject key;
	[HideInInspector] public bool collected;

	void Start(){
		collected = false;
	}

	void Update()
	{
		//Not required, but for fun why not try adding a Key Floating Animation here :)
		transform.Translate(0,Mathf.Sin(Time.time)/100,0,Space.World);
	}

	public void OnKeyClicked()
	{
        // Instatiate the KeyPoof Prefab where this key is located
        // Make sure the poof animates vertically
		Object.Instantiate (keyPoof, key.transform.position , Quaternion.Euler(-90, 0, 0 ));
        // Call the Unlock() method on the Door
		door.Unlock();
        // Set the Key Collected Variable to true
		collected = true;
        // Destroy the key. Check the Unity documentation on how to use Destroy
		Destroy(key);
    }

}
