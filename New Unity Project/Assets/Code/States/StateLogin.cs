using UnityEngine;
using System.Collections;
using Assets.Code.Interfaces;

namespace Assets.Code.States
{
	public class StateRegister : InterfacesStados
	{
		private GameManager manager;
		public GameObject cubo;
		public string userName = "CORREO";
		public string password = "X X X X X X";
		private GUISkin mySkin;

		public StateRegister (GameManager managerRef)
		{
			manager = managerRef;
			if(Application.loadedLevelName != "Login")
				Application.LoadLevel("Login");

			mySkin = manager.gameDataRef.mySkin;
		}

		public void OnStateLevelLoad (int level)
		{

		}

		public void StateUpdate ()
		{
		}

		public void ShowIt ()
		{			
			GUI.skin = mySkin;

			if(GUI.Button(new Rect(Screen.width * 0.60f, Screen.height * 0.75f - 40, 60, 20), 
			              new GUIContent("Entrar", "Rellena el <i>usuario</i> y <b>contrasenia</b> primero")))
			{
				manager.gameDataRef.userName = this.userName;
				manager.gameDataRef.password = this.password;
				manager.SwitchState(new StateHome(manager));
			}

			if(GUI.Button(new Rect(Screen.width * 0.15f, Screen.height * 0.75f - 40, 110, 20), "Nuevo Registro", "button"))
			{
				manager.SwitchState(new StateNewRegister(manager));
			}

			GUI.Label(new Rect(Input.mousePosition.x + 20,Screen.height - Input.mousePosition.y - 20,
			                   150, 150), GUI.tooltip);

			userName = GUI.TextField(new Rect(Screen.width*0.1f, Screen.height*0.38f, Screen.width*0.75f, 20.0f), userName, 25);
			password = GUI.TextField(new Rect(Screen.width*0.1f, Screen.height*0.50f, Screen.width*0.75f, 20.0f), password, 25);
		}
	}
}

