using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
	public float speed;
	
	void Start ()
	{
		rigidbody.velocity = transform.forward * speed;
	}
}