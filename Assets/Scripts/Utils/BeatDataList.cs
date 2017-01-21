using UnityEngine;
using System.Collections.Generic;

[System.Serializable]
public class BeatDataList {
    public List<BeatData> list;

    public BeatDataList() {
        list = new List<BeatData>();
    }
}
