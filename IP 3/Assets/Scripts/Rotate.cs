using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour
{
	public float tumble;
	
	void Start ()
	{
		rigidbody.angularVelocity = Random.insideUnitSphere * tumble; 
	}
}
