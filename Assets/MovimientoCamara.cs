using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCamara : MonoBehaviour {
    public Vector3 velocidad;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        Vector3 deltaVelocidad = Time.deltaTime * velocidad;
        transform.Translate(deltaVelocidad);
    }
}
