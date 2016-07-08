using UnityEngine;
using System.Collections;

public class AsteroidMover : MonoBehaviour
{
	public float speed;
	public Vector3 direction;

	void Start ()
	{
		GetComponent<Rigidbody>().velocity = direction * speed;
	}
}
