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
        Beat beat = col.GetComponent<Beat>();
        beat.Begin();
        queue.Enqueue( beat );
        
    }

    void OnTriggerExit2D(Collider2D col) {
        if (col.tag != "Droplet") return;
        Beat beat = col.GetComponent<Beat>();
        beat.Stop();
        if (queue.Contains(beat)) {
            queue.Dequeue().controller.SetTrigger(AnimationController.ANIM_MISS);
            ScoreManager.instance.SetMiss();
        }
    }
}
