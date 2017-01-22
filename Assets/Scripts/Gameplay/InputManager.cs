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
        Beat activeBeat = hit.currentBeat;
        if(activeBeat == null) {
            print("Null!");
            return;
        }
        activeBeat.controller.SetTrigger(AnimationController.ANIM_HIT);
        activeBeat.Stop();
        InputPrecision precision = activeBeat.precision;
        string status = precision.ToString();
        int value = (int)precision;
        print(string.Format("Status: {0} Value: {1} Hits: {2}", status, value, i));
    }

}
