using UnityEngine;
using System.Collections;

public class MostrarUsuario : MonoBehaviour {


	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void DisplayText (string newMessage)
	{
		guiText.text = newMessage;
	}
}
