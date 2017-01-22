using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitTrigger : MonoBehaviour {

    public Beat currentBeat;

	void OnTriggerEnter2D(Collider2D col) {
        currentBeat = col.GetComponent<Beat>();
        currentBeat.Begin();
    }

    void OnTriggerExit2D(Collider2D col) {
        SpawnDroplet.instance.Deactivate(col.GetComponent<PoolObject>());
        currentBeat = null;
    }
}
