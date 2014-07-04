using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States
{
	public class StateNewRegister : InterfacesStados
	{
		private GameManager manager;
		private string userNickName = "USUARIO";
		private string password = "X X X X X";
		private string confirmPass = "X X X X X";
		private string country = "PAIS";
		private string userName = "NOMBRE";
		private string userLastName = "APELLIDO";
		private string phone = "(000) 000-0000";
		private string mail = "CORREO";

		private GUISkin mySkin;

		private int toolbarInt;
		private string[] toolbarGender = {"Hombre", "Mujer"};
		public StateNewRegister (GameManager managerRef)
		{
			manager = managerRef;
			if (Application.loadedLevelName != "Registro Nuevo")
				Application.LoadLevel ("Registro Nuevo");

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

			userNickName = GUI.TextField (new Rect (Screen.width * 0.1f, Screen.height * 0.38f, Screen.width * 0.75f, 20.0f), userNickName, 15);
			password = GUI.TextField (new Rect (Screen.width * 0.1f, Screen.height * 0.50f, Screen.width * 0.38f, 20.0f), password, 25);
			confirmPass = GUI.TextField (new Rect (Screen.width * 0.5f, Screen.height * 0.50f, Screen.width * 0.38f, 20.0f), confirmPass, 25);
			userName = GUI.TextField (new Rect (Screen.width * 0.1f, Screen.height * 0.62f, Screen.width * 0.38f, 20.0f), userName, 25);
			userLastName = GUI.TextField (new Rect (Screen.width * 0.5f, Screen.height * 0.62f, Screen.width * 0.38f, 20.0f), userLastName, 25);
			country = GUI.TextField (new Rect (Screen.width * 0.1f, Screen.height * 0.74f, Screen.width * 0.38f, 20.0f), country, 25);
			phone = GUI.TextField (new Rect (Screen.width * 0.5f, Screen.height * 0.74f, Screen.width * 0.38f, 20.0f), phone, 25);
			mail = GUI.TextField (new Rect (Screen.width * 0.1f, Screen.height * 0.86f, Screen.width * 0.55f, 20.0f), mail, 25);

			toolbarInt = GUI.SelectionGrid(new Rect(Screen.width * 0.7f, Screen.height * 0.82f, 50, 40), toolbarInt, toolbarGender, 1, "toggle");

			if(GUI.Button(new Rect(Screen.width * 0.30f, Screen.height * 0.93f, 80.0f, 20.0f), new GUIContent("Registrar", "Tiene que completar todos los campos")))
			{
				manager.gameDataRef.userName = userNickName;
				manager.SwitchState(new StateMenu(manager));
			}
		}
	}
}

