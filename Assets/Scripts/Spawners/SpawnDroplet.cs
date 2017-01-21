using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDroplet : MonoBehaviour {

    public Rect cameraRect;
    PoolObject[] pool;
    List<PoolObject> active;
    Queue<PoolObject> inactive;

    void Awake() {
        pool = FindObjectsOfType<PoolObject>();
    }

	// Use this for initialization
	void Start () {
        inactive = new Queue<PoolObject>(pool);
        active = new List<PoolObject>(pool.Length);
	}
	
	public void SpawnObject() {
        if(inactive.Count <= 0) {
            return;
        }
        float xSpawn = Random.Range(cameraRect.x, cameraRect.xMax);
        float ySpawn = Random.Range(cameraRect.y, cameraRect.yMax);
        PoolObject toActivate = inactive.Dequeue();
        toActivate.ShowObject(new Vector3(xSpawn, ySpawn));
        toActivate.index = active.Count;
        active.Add(toActivate);
        
    }

    public void Deactivate(int index) {
        PoolObject toDeactivate = active[index];
        active.RemoveAt(index);
        toDeactivate.HideObject();
        toDeactivate.index = -1;
        inactive.Enqueue(toDeactivate);
    }

}
