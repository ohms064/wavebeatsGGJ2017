using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitTrigger : MonoBehaviour {

    public Beat currentBeat;

	void OnTriggerEnter2D(Collider2D col) {
        if (col.tag != "Droplet") return;
        currentBeat = col.GetComponent<Beat>();
        currentBeat.Begin();
    }

    void OnTriggerExit2D(Collider2D col) {
        if (col.tag != "Droplet") return;
        col.GetComponent<Beat>().Stop();
        currentBeat.controller.SetTrigger(AnimationController.ANIM_MISS);
        currentBeat = null;
    }
}
