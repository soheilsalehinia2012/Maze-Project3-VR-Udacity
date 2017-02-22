using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
	[HideInInspector] public bool locked;
    // Create a boolean value called "opening" that can be checked in Update() 
	[HideInInspector] public bool opening;
	[HideInInspector] public bool fullyRaised;

	public AudioClip doorLockedSound;
	public AudioClip doorOpenedSound;
	public AudioSource doorAudioSource;
	public GameObject leftDoor;
	public GameObject rightDoor;
	public BoxCollider doorBoxCollider;

	void Start(){
		locked = true;
		opening = false;
		fullyRaised = false;
	}

    void Update() {
        // If the door is opening and it is not fully raised
            // Animate the door raising up
		if (opening == true && fullyRaised == false){
			if (leftDoor.transform.rotation.z > 0) {
				leftDoor.transform.Rotate (0, 0, -20 * Time.deltaTime);
			}
			if (rightDoor.transform.rotation.z > 0) {
				rightDoor.transform.Rotate (0, 0, 20 * Time.deltaTime);
			} else {
				fullyRaised = true;
				doorBoxCollider.enabled = false;
			}
			
		}
    }

    public void OnDoorClicked() {
        // If the door is clicked and unlocked
            // Set the "opening" boolean to true
        // (optionally) Else
            // Play a sound to indicate the door is locked
		if (locked == false) {
			opening = true;
			doorAudioSource.clip = doorOpenedSound;
			doorAudioSource.Play ();
		} else {
			doorAudioSource.clip = doorLockedSound;
			doorAudioSource.Play ();
		}
    }

    public void Unlock()
    {
        // You'll need to set "locked" to false here
		locked = false;
    }
}
