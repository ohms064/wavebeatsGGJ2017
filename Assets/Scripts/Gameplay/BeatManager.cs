﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatManager : MonoBehaviour, AudioProcessor.AudioCallbacks {
    [Range(0f, 1f)]
    public float badRange, goodRange, greatRange, perfectRange, missRange;
    public static BeatManager instance;
    SpawnDroplet spawner;

    //68 beats
    public void onOnbeatDetected() {
        PoolObject beat = spawner.SpawnObject();
        if(beat != null) {
            beat.gameObject.GetComponent<Beat>().Begin();
        }
    }

    public void onSpectrum(float[] spectrum) {
    }

    // Use this for initialization
    void Awake () {
        AudioProcessor processor = FindObjectOfType<AudioProcessor>();
        processor.addAudioCallback(this);
        spawner = FindObjectOfType<SpawnDroplet>();
        instance = this;
    }
	
    public void RecycleBeat(Beat beat) {
        spawner.Deactivate(beat.poolObject);
    }
}
