using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShader : MonoBehaviour {
    Camera mainCam;
    public Shader camShader;
	// Use this for initialization
	void Start () {
        mainCam = Camera.main;
        mainCam.RenderWithShader(camShader, "");
	}
}
