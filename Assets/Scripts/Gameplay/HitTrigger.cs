using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitTrigger : MonoBehaviour {

    public Queue<Beat> queue;

    void Start() {
        queue = new Queue<Beat>();
    }

	void OnTriggerEnter2D(Collider2D col) {
        if (col.tag != "Droplet") return;
        queue.Enqueue( col.GetComponent<Beat>());
        queue.Peek().Begin();
    }

    void OnTriggerExit2D(Collider2D col) {
        if (col.tag != "Droplet") return;
        col.GetComponent<Beat>().Stop();
        queue.Dequeue().controller.SetTrigger(AnimationController.ANIM_MISS);
    }
}
