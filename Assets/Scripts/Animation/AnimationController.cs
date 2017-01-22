using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour {

    public const string ANIM_BEGIN = "Begin", ANIM_HIT = "PlayerHit", ANIM_MISS = "Miss";
    Animator animControl;

    void Start() {
        animControl = GetComponent<Animator>();
    }

    public void SetTrigger(string trigger) {
        animControl.SetTrigger(trigger);
    }


}
