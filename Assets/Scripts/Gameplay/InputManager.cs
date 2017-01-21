using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	public void OnTouchDown () {
        print("Touch!");
        Beat activeBeat = SpawnDroplet.instance.ActiveBeat;
        if(activeBeat == null) {
            return;
        }
        SpawnDroplet.instance.Deactivate(activeBeat.poolObject);
        InputPrecision precision = activeBeat.precision;
        string status = precision.ToString();
        int value = (int)precision;
        print(string.Format("Status: {0} Value: {1}", status, value));
    }

}
