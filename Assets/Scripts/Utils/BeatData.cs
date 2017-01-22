using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class BeatData {
    public float time;
    public int id;

    public List<BeatData> LoadFromJson(TextAsset jsonAsset) {
        return JsonUtility.FromJson<List<BeatData>>( jsonAsset.text);
    }

    public BeatData(float time, int id) {
        this.time = time;
        this.id = id;
    }

   
}
