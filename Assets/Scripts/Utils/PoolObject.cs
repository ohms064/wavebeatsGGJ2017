using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolObject : MonoBehaviour {
    [HideInInspector]
    public bool isInPlay = false;
    [HideInInspector]
    public int index;

    public void HideObject() {
        transform.position = new Vector3(100, 100, 100);
        this.enabled = false;
        isInPlay = false;
    }

    public bool ShowObject(Vector3 toPosition) {
        if (isInPlay) {
            return false;
        }
        isInPlay = true;
        transform.position = toPosition;
        return true;
    }

    public bool ShowObject(Vector3 toPosition, float duration) {
        if (isInPlay) {
            return false;
        }
        transform.position = toPosition;
        isInPlay = true;
        return true;
    }
}
