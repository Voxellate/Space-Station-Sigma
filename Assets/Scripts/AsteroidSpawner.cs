using UnityEngine;
using System.Collections;

public class AsteroidSpawner : MonoBehaviour {

	public Vector2 spawnOrigin;
	public Vector3 spawnBounds;
	public GameObject[] hazards;

	void Start ()
	{
		StartCoroutine (SpawnAsteroids ());
	}

	IEnumerator SpawnAsteroids ()
	{
		while (true) {
			GameObject hazard = hazards[Random.Range(0, hazards.Length)];
			Vector3 spawnPosition = new Vector3 (Random.Range(spawnOrigin.x, spawnOrigin.x + spawnBounds.x), Random.Range(-10, spawnBounds.y), Random.Range(spawnOrigin.y, spawnOrigin.y + spawnBounds.z));
			Quaternion spawnRotation = Quaternion.identity;
			Instantiate (hazard, spawnPosition, spawnRotation);
			yield return new WaitForSeconds (1);
		}
	}
}
