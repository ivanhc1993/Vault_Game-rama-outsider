using System.Collections;
using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States
{
	public class StatePuja : InterfacesStados
	{
		private GameManager manager;
		private GUISkin mySkin;
		
		public StatePuja (GameManager managerRef)
		{
			manager = managerRef;
			if(Application.loadedLevelName != "Puja")
				Application.LoadLevel("Puja");
			
			mySkin = manager.gameDataRef.mySkin;

		}
		
		public void StateUpdate ()
		{
			
		}
		
		public void ShowIt ()
		{
			GUI.skin = mySkin;

			if(GUI.Button(new Rect(Screen.height * 0.01f, Screen.height * 0.03f, 20, 20), new GUIContent("", "Click para salir"), "buttonClose"))
			{
				manager.SwitchState(new StateHome(manager));
			}

		}
		
		public void OnStateLevelLoad (int level)
		{
		
		}

	}
}

