using UnityEngine;
using System.Collections;

public class Rotar : MonoBehaviour {

	// Update is called once per frame
	void Update () 
	{
		transform.Rotate (Time.deltaTime*60, Time.deltaTime*60, Time.deltaTime*60);
	}
}
