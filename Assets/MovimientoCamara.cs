using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCamara : MonoBehaviour {
    public Vector3 velocidad;
    public float limite;
    public float valorAbsoluto;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        valorAbsoluto= Mathf.Abs(transform.position.x);
        if (valorAbsoluto<limite)
            
        {

            Vector3 deltaVelocidad = Time.deltaTime * velocidad;
            transform.Translate(deltaVelocidad);
        }
    }
}
