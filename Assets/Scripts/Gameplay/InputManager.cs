using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
#if UNITY_ANDROID
        if(Input.touchCount > 0) {

        }
#else

#endif
    }

}
