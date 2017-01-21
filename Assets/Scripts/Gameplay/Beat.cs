using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beat : MonoBehaviour {
    [HideInInspector]
    public InputPrecision precision;
    BeatManager manager;
    [HideInInspector]
    public PoolObject poolObject;
    bool hit = false;

    void Start() {
        manager = BeatManager.instance;
        poolObject = GetComponent<PoolObject>();
    }

    public void Begin() {
        StartCoroutine("StartCycle");
    }

    private IEnumerator StartCycle() {
        hit = false;
        yield return new WaitForSeconds(manager.badRange);
        precision = InputPrecision.BAD;
        yield return new WaitForSeconds(manager.goodRange);
        precision = InputPrecision.GOOD;
        yield return new WaitForSeconds(manager.greatRange);
        precision = InputPrecision.GREAT;
        yield return new WaitForSeconds(manager.perfectRange);
        precision = InputPrecision.PERFECT;
        yield return new WaitForSeconds(manager.missRange);
        precision = InputPrecision.MISS;
        if (!hit) {
            BeatManager.instance.RecycleBeat(this);
        }
    }

    public InputPrecision OnHit() {
        BeatManager.instance.RecycleBeat(this);
        hit = true;
        return precision;
    }
}
