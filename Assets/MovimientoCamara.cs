using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCamara : MonoBehaviour {
    public Vector3 vector3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        Vector3 vector4 = Time.deltaTime * vector3;
        transform.Translate(vector4);
    }
}
