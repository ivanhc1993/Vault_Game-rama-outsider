using UnityEngine;
using Assets.Code.Interfaces;
using Assets.Code.States;
using System.Collections;

public class GameManager : MonoBehaviour 
{
	private static GameManager centinelaGameManager;
	public InterfacesStados estadoActivo;
	public GameData gameDataRef;

	void Awake ()
	{
		if(centinelaGameManager == null)
		{
			centinelaGameManager = this;
			DontDestroyOnLoad(gameObject);
		}else
		{
			DestroyImmediate(gameObject);
		}
	}


	void Start ()
	{
		gameDataRef = GetComponent<GameData>();
		estadoActivo = new StateRegister (this);

	}

	void OnLevelWasLoaded (int level)
	{
		if(estadoActivo != null)
			estadoActivo.OnStateLevelLoad(level);
	}

	void Update () 
	{
		if(estadoActivo != null)
			estadoActivo.StateUpdate ();
	}

	void OnGUI  ()
	{
		if(estadoActivo != null)
			estadoActivo.ShowIt ();
	}

	public void SwitchState (InterfacesStados estadoNuevo)
	{
		estadoActivo = estadoNuevo;
	}


}
