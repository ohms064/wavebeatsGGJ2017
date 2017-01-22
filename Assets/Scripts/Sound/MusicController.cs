using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour {
    AudioSource music;
    public float initDelay = 5;
    public float finishDelay = 5f;
	// Use this for initialization
	void Start () {
        music = GetComponent<AudioSource>();
        Invoke("Begin", initDelay);
        Invoke("OnMusicEnd", finishDelay + music.clip.length);
	}
	
    void Begin() {
        music.Play();
    }

    void OnMusicEnd() {
        LoadSceneManager.instance.LoadNextScene(Scenes.MAIN_MENU);
    }
}
