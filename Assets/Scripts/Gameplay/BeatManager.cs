using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class BeatManager : MonoBehaviour, AudioProcessor.AudioCallbacks {
    [Range(0f, 1f)]
    public float badRange, goodRange, greatRange, perfectRange, missRange;
    public static BeatManager instance;
    private BeatDataList data;
    private float currentTime;
    int id = 1;
    public int interval = 2;

    public string jsonFileName;

    // Use this for initialization
    void Awake () {
        AudioProcessor processor = FindObjectOfType<AudioProcessor>();
        processor.addAudioCallback(this);
        SpawnDroplet.instance = FindObjectOfType<SpawnDroplet>();
        instance = this;

#if UNITY_EDITOR
        jsonFileName = "Data/" + jsonFileName;
#elif UNITY_STANDALONE
        jsonFileName = "wavebeats_Data/Resources/" + jsonFileName;
#endif
    }

    void Start() {
        data = new BeatDataList();
        currentTime = Time.time;
    }

    void Update() {
        currentTime += Time.deltaTime;
    }

    //68 beats
    public void onOnbeatDetected() {
        if (id % interval == 0) {
            PoolObject beat = SpawnDroplet.instance.SpawnObject();
            if (beat != null) {
                beat.gameObject.GetComponent<Beat>().Begin();
            }
        }
        data.list.Add(new BeatData(currentTime, id));
        id++;
    }

    public void onSpectrum(float[] spectrum) {
    }

    public void SaveJson() {

        StreamWriter sw = new StreamWriter(jsonFileName);
        string jsonStr = JsonUtility.ToJson(data);
        sw.Write(jsonStr);
        sw.Close();
    }
}
