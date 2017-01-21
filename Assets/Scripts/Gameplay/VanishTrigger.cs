using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VanishTrigger : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D col) {
        SpawnDroplet.instance.Deactivate(col.GetComponent<PoolObject>());
    }
}
