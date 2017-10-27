using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour {
    [SerializeField] protected GameObject pickupPrefab;
    [SerializeField] string prefabName;
    public int pickupsRemaining = 5;

    void Start() {
        pickupPrefab = Resources.Load(prefabName) as GameObject;
    }

    public virtual GameObject GrabPickup() {
        GameObject.Destroy(gameObject);
        return pickupPrefab;
    }
}
