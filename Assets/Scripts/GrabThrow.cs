using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabThrow : MonoBehaviour {
    [SerializeField] Transform pickupSpawn;

    private GameObject heldObject;
    private bool holdingItem = false;

    void Update() {
		if (Input.GetButtonDown ("Fire1") || Input.GetButtonDown ("Fire2")) {
			if (!holdingItem) {
				RaycastHit hitInfo;
				// Raycast from the center of the screen two units forward
				if (Physics.Raycast (Camera.main.transform.position, Camera.main.transform.forward, out hitInfo, 2)) {
					Pickup pickup = hitInfo.transform.GetComponentInParent<Pickup> ();
					if (pickup != null) {
						GameObject pickupObj = pickup.GrabPickup ();
						if (pickupObj != null) {
							heldObject = GameObject.Instantiate (pickupObj, pickupSpawn);
							holdingItem = true;
						}
					}
				}
			} else {
				heldObject.transform.parent = null;
				heldObject.GetComponent<Collider> ().enabled = true;
				Rigidbody heldRB = heldObject.GetComponent<Rigidbody> ();
				heldRB.isKinematic = false;
				Vector3 forward = heldRB.transform.forward;
				Vector3 throwDir = new Vector3 (forward.x, forward.y + .4f, forward.z);
				if (Input.GetButtonDown ("Fire1")) {
					heldRB.AddForce (throwDir * 500);
				} else if (Input.GetButtonDown ("Fire2")) {
					heldRB.AddForce (throwDir * 150);
				}
				holdingItem = false;
			}
		}
    }
}
