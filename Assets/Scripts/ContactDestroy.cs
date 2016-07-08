using UnityEngine;
using System.Collections;

public class ContactDestroy : MonoBehaviour
{
	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Boundary")
		{
			Destroy (gameObject);
		}
	}
}