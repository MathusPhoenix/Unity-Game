using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	public int numberToSpawn;
	public List<GameObject> spawnPools;
	public GameObject quad;
	
    // Start is called before the first frame update
    void Start()
    {
		spawnObjects();
    }
	
	public void spawnObjects() {
		int randomItem = 0;
		GameObject toSpawn = null;
		Collider2D c = quad.GetComponent<Collider2D>();
		
		float screenX,screenY;
		Vector2 pos;
		
		for (int i = 0; i < numberToSpawn; i++) {
			
			//Random Object to spawn
			randomItem = Random.Range(0, spawnPools.Count);
			toSpawn = spawnPools[randomItem];
			
			//Random spawn position
			screenX = Random.Range(c.bounds.min.x , c.bounds.max.x);
			screenY = Random.Range(c.bounds.min.y , c.bounds.max.y);
			pos = new Vector2(screenX,screenY);
			
			//Spawn
			Instantiate(toSpawn , pos , toSpawn.transform.rotation);
		}

	}
}
