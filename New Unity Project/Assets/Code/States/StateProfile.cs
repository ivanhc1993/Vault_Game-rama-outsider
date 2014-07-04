using System;
using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States
{
	public class StateProfile : InterfacesStados
	{
		private GameObject guiUserName;
		private GameObject guiPassword;
		private GameManager manager;
		private string refAccount;
		private string phone;
		private string mail;
		private bool editable;
		private Rect positionButton;
		private Rect titleScreenPos;
		private GUISkin mySkin;
		private int toolbarInt;
		private Texture[] toolbarTex;

		public StateProfile (GameManager managerRef)
		{
			manager = managerRef;
			editable = false;
			if(Application.loadedLevelName != "Perfil")
				Application.LoadLevel("Perfil");

			this.mySkin = manager.gameDataRef.mySkin;
		}

		public void OnStateLevelLoad (int level)
		{
			this.refAccount = manager.gameDataRef.refAccount;
			this.phone = manager.gameDataRef.phone;
			this.mail = manager.gameDataRef.mail;
			this.positionButton = GameObject.Find("GUI_pop_information").guiText.GetScreenRect();
			this.titleScreenPos = GameObject.Find("GUI_pop_title").guiText.GetScreenRect();
			this.toolbarTex = manager.gameDataRef.payMethod;

			this.guiUserName = GameObject.Find("GUI_pop_userName");
			if(guiUserName != null)
			{
				guiUserName.GetComponent<MostrarUsuario>().DisplayText(manager.gameDataRef.userName);
			}

			guiUserName = GameObject.Find("GUI_pop_password");
			if(guiUserName != null)
			{
				guiUserName.GetComponent<MostrarUsuario>().DisplayText(manager.gameDataRef.password);
			}
		}

		public void StateUpdate ()
		{

		}

		public void ShowIt ()
		{
			GUI.skin = mySkin;

			if(GUI.Button(new Rect(titleScreenPos.xMax, Screen.height * 0.06f, 20, 20), new GUIContent("", "Click para salir"), "buttonClose"))
			{
				manager.SwitchState(new StateHome(manager));
			}

			switch(editable) //Para editar el campo de telefono y correo cuando se oprime el boton "editar" o "aceptar"
			{
			case false:
				GUI.Box(new Rect(Screen.width * 0.45f, Screen.height * 0.34f, Screen.width * 0.45f, 20), phone);
				GUI.Box(new Rect(Screen.width * 0.45f, Screen.height * 0.29f, Screen.width * 0.45f, 20), mail);

				if(GUI.Button(new Rect(positionButton.xMax + 20, Screen.height * 0.8f, 50, 20), "Editar"))
				{
					IsEditable();
				}
				break;

			case true:

				phone = GUI.TextField(new Rect(Screen.width * 0.45f, Screen.height * 0.34f, Screen.width * 0.45f, 20), phone);
				mail = GUI.TextField(new Rect(Screen.width * 0.45f, Screen.height * 0.29f, Screen.width * 0.45f, 20), mail);

				if(GUI.Button(new Rect(positionButton.xMax + 20, Screen.height * 0.7f, 50, 20), "Aceptar"))
				{
					manager.gameDataRef.refAccount = this.refAccount;
					manager.gameDataRef.phone = this.phone;
					manager.gameDataRef.mail = this.mail;
					IsEditable();
				}
				break;
			}

			GUI.Box(new Rect(Screen.width * 0.45f, Screen.height * 0.74f, Screen.width * 0.45f, 20), refAccount);

			//barra de seleccion de metodo de pago
			toolbarInt = GUI.Toolbar(new Rect(Screen.width * 0.5f, Screen.height * 0.64f, 40, 40), 
			                               toolbarInt, toolbarTex, "toggle");

			//Este boton me permite entrar a la pantala de logros
			if(GUI.Button(new Rect(positionButton.xMin, Screen.height * 0.84f, 50, 50), "Logros", "buttonAchiev"))
			{

			}

			if(GUI.Button(new Rect(positionButton.xMin + 60, Screen.height * 0.84f, 50, 50), "Datos", "buttonData"))
			{

			}
		}

		/**
		 * <summary>
		 * funcion encargada de modificar el valor de la booleana "editable"
		 * </summary>
		 * 
		 * @param
		 * @return
		 */
		private void IsEditable ()
		{
			if(editable == true)
				editable = false;

			else
				editable = true;
		}
	}
}

