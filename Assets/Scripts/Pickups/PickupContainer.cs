using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupContainer : Pickup {
    [SerializeField] TextMesh counter;
    [SerializeField] MeshRenderer pickupSpinner;
    [SerializeField] Material zeroRemaining;

    void Start() {
        counter.text = pickupsRemaining.ToString();
    }

    override public GameObject GrabPickup() {
        if (pickupsRemaining > 0) {
            pickupsRemaining -= 1;
            if (pickupsRemaining == 0) {
                pickupSpinner.material = zeroRemaining;
            }
            counter.text = pickupsRemaining.ToString();
            return pickupPrefab;
        } else {
            return null;
        }
    }
}
