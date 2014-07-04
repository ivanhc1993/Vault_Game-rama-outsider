using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States
{
	public class StateHome : InterfacesStados
	{
		private GameManager manager;
		private GUISkin mySkin;

		public StateHome (GameManager managerRef)
		{
			manager = managerRef;
			if(Application.loadedLevelName != "Home")
				Application.LoadLevel("Home");

			mySkin = manager.gameDataRef.mySkin;
		}

		public void StateUpdate ()
		{

		}

		public void ShowIt ()
		{
			GUI.skin = mySkin;

			if(GUI.Button(new Rect(Screen.width * 0.35f, Screen.height * 0.7f,70, 20), "Iniciar"))
			{
				manager.SwitchState(new StatePlay(manager));
			}

			if(GUI.Button(new Rect(Screen.width * 0.1f, Screen.height * 0.8f, 50, 50), "Perfil", "buttonProfile"))
			{
				manager.SwitchState(new StateProfile(manager));
			}
			
			if(GUI.Button(new Rect(Screen.width * 0.4f, Screen.height * 0.8f, 50, 50), "Confi.", "buttonConfig"))
			{
				manager.SwitchState(new StateMenu(manager));
			}
			
			if(GUI.Button(new Rect(Screen.width * 0.7f,Screen.height * 0.8f, 50, 50), "Tienda", "buttonStore"))
			{
				manager.SwitchState(new StateStore(manager));
			}
		}

		public void OnStateLevelLoad (int level)
		{

		}
	}
}

