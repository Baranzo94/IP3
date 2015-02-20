using UnityEngine;
using System.Collections;

public class DropOff : MonoBehaviour
{
	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name == "Touch Object")
		{
			Destroy(col.gameObject);
		}
	}
}