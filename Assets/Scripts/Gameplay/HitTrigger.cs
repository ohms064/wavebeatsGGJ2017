using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitTrigger : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col) {
        col.GetComponent<Beat>().Begin();
    }

    void OnTriggerExit2D(Collider2D col) {
        SpawnDroplet.instance.Deactivate(col.GetComponent<PoolObject>());
    }
}
