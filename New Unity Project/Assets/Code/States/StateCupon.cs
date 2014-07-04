using System.Collections;
using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States
{
	public class StateCupon : InterfacesStados
	{
		private GameManager manager;
		private GUISkin mySkin;
		
		public StateCupon (GameManager managerRef)
		{
			manager = managerRef;
			if(Application.loadedLevelName != "Cupon")
				Application.LoadLevel("Cupon");
			
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

			// Boton Que pasa a la vista de estadisticas de pujas
			if(GUI.Button(new Rect(Screen.width * 0.3f, Screen.height * 0.8f, Screen.width * 0.2f, Screen.width * 0.15f), "", "buttonEstPuj"))
			{

			}

			// Boton Que pasa a la vista de sub
			if(GUI.Button(new Rect(Screen.width * 0.3f + Screen.width * 0.2f, Screen.height * 0.8f, Screen.width * 0.2f, Screen.width * 0.15f), "", "buttonSub"))
			{
				
			}
		}
		
		public void OnStateLevelLoad (int level)
		{
		
		}

	}
}

