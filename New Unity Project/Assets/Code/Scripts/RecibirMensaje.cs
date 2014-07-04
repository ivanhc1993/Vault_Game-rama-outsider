using UnityEngine;
using System.Collections;

public class RecibirMensaje : MonoBehaviour {

	public GUIText textModule;

	void Start ()
	{
		textModule = GetComponentInChildren<GUIText>();
	}

	public void EscribirEnModulo (string mensaje)
	{
		textModule.text = mensaje;
		Comparar ();
		StopCoroutine ("Reiniciar");
		StartCoroutine ("Reiniciar", 2.0F);
	}
	
	private IEnumerator Reiniciar (float waitTime)
	{
		yield return new WaitForSeconds (waitTime);
		EscribirEnModulo("-");
	}
	
	private bool Comparar()
	{
		return (textModule.text == "5"); 
	}
}
