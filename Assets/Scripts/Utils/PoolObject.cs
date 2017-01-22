using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolObject : MonoBehaviour {
    [HideInInspector]
    public bool isInPlay = false;
    [HideInInspector]
    public int index;
    public ISpawnable listener;
    private Vector3 originalPlace;
    public Beat beat; //Esto talvez sea mejor que PoolObject sea una interfaz IPoolable y que Beat implemente esta interfaz coomo está definida esta clase.

    void Awake() {
        beat = GetComponent<Beat>();
        originalPlace = transform.position;
    }

    public void HideObject() {
        transform.position = originalPlace;
        this.enabled = false;
        isInPlay = false;
        listener.Desapawn();
    }

    public bool ShowObject(Vector3 toPosition) {
        if (isInPlay) {
            return false;
        }
        isInPlay = true;
        transform.position = toPosition;
        listener.Spawn();
        return true;
    }
}
