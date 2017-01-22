using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

    HitTrigger hit;
    int i = 0;

    void Start() {
        hit = FindObjectOfType<HitTrigger>();
    }
    
	// Update is called once per frame
	public void OnTouchDown () {
        i++;
        print("Touch!");
        Beat activeBeat = hit.queue.Dequeue();
        if(activeBeat == null) {
            print("Null!");
            return;
        }
        InputPrecision precision = activeBeat.precision;
        switch (precision) {
            case InputPrecision.MISS:
                activeBeat.controller.SetTrigger(AnimationController.ANIM_MISS);
                ScoreManager.instance.SetMiss();
                break;
            case InputPrecision.NICE:
                activeBeat.controller.SetTrigger(AnimationController.ANIM_HIT);
                ScoreManager.instance.SetNice();
                break;
            case InputPrecision.PERFECT:
                activeBeat.controller.SetTrigger(AnimationController.ANIM_HIT);
                ScoreManager.instance.SetPerfect();
                break;
        }
        activeBeat.Stop();

        ScoreManager.instance.UpdateScore(100 * (int)precision);

        string status = precision.ToString();
        int value = (int)precision;
        print(string.Format("Status: {0} Value: {1} Hits: {2}", status, value, i));
    }

}
