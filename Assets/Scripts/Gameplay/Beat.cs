using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beat : MonoBehaviour, ISpawnable {
    [HideInInspector]
    public InputPrecision precision;
    BeatManager manager;
    [HideInInspector]
    public PoolObject poolObject;
    Rigidbody2D rb;
    void Start() {
        manager = BeatManager.instance;
        poolObject = GetComponent<PoolObject>();
        poolObject.listener = this;
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
    }

    public void Begin() {
        StartCoroutine("StartCycle");
    }

    private IEnumerator StartCycle() {
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
    }

    public InputPrecision OnHit() {
        SpawnDroplet.instance.Deactivate(poolObject);
        return precision;
    }

    public void Spawn() {
        rb.gravityScale = 1;
    }

    public void Desapawn() {
        rb.gravityScale = 0;
        rb.velocity = Vector2.zero;
    }
}
