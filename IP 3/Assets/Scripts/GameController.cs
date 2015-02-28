using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
	public GameObject hazard;
	public Vector3 spawnValues;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;
	
	void Start ()
	{
		StartCoroutine (SpawnWaves ());
	}

	void Update() {
		if (Input.GetMouseButton(0))
			Debug.Log("Pressed left click.");
		
		if (Input.GetMouseButton(1))
			Debug.Log("Pressed right click.");
		
		if (Input.GetMouseButton(2))
			Debug.Log("Pressed middle click.");
		
	}
	
	IEnumerator SpawnWaves ()
	{
		yield return new WaitForSeconds (startWait);
		while (true)
		{
			for (int i = 0; i < hazardCount; i++)
			{
				Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (hazard, spawnPosition, spawnRotation);
				yield return new WaitForSeconds (spawnWait);
			}
			yield return new WaitForSeconds (waveWait);
		}
	}
}
