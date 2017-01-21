using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDroplet : MonoBehaviour {

    public Rect spawnRect;
    PoolObject[] pool;
    List<PoolObject> active;
    Queue<PoolObject> inactive;

    void Awake() {
        pool = FindObjectsOfType<PoolObject>();
        int[] arr = new int[3];
        arr[0] = 1;
        arr[1] = 3;
        arr[2] = 10;

        for(int i = 0; i < arr.Length; i++) {
            arr[0] = i;
        }
    }

	// Use this for initialization
	void Start () {
        inactive = new Queue<PoolObject>(pool);
        active = new List<PoolObject>(pool.Length);
	}
	
	public PoolObject SpawnObject() {
        if(inactive.Count <= 0) {
            return null;
        }
        float xSpawn = Random.Range(spawnRect.x, spawnRect.xMax);
        //float ySpawn = Random.Range(spawnRect.y, spawnRect.yMax);
        PoolObject toActivate = inactive.Dequeue();
        toActivate.ShowObject(new Vector3(xSpawn, spawnRect.center.y));
        toActivate.index = active.Count;
        active.Add(toActivate);
        return toActivate;
        
    }

    public void Deactivate(PoolObject toDeactivate) {
        active.Remove(toDeactivate);
        toDeactivate.HideObject();
        toDeactivate.index = -1;
        inactive.Enqueue(toDeactivate);
    }
#if UNITY_EDITOR
    void OnDrawGizmos() {
        Gizmos.color = Color.cyan;
        GizmoUtils.DrawRect(spawnRect);
    }
#endif
}
