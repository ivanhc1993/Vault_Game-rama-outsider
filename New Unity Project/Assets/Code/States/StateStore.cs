using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States
{
	public class StateStore : InterfacesStados
	{
		private GameManager manager;
		private GUISkin mySkin;
		private int nivel;
		private int moduleActivo;
		private Rect positionButton;
		private Texture BarraEncabezadoAplicacion;
				
		public StateStore (GameManager managerRef)
		{
			manager = managerRef;
			if(Application.loadedLevelName != "Store")
				Application.LoadLevel("Store");
			
			mySkin = manager.gameDataRef.mySkin;

		}
		
		public void StateUpdate ()
		{
			
		}
		
		public void ShowIt ()
		{
			GUI.skin = mySkin;

			if(GUI.Button(new Rect(positionButton.xMin + 10, Screen.height * (1 - positionButton.xMin / Screen.height) - 20,
			                       20, 20), new GUIContent("", "Click para salir"), "buttonClose"))
			{
				manager.SwitchState(new StateHome(manager));
			}

			if(GUI.Button(new Rect(positionButton.xMin, Screen.height * 0.84f, 30, 30), "", "buttonPublicidad"))
			{
				
			}
			
			if(GUI.Button(new Rect(positionButton.xMin + 60, Screen.height * 0.84f, 50, 50), "Dato", "buttonData"))
			{

			}

			GUI.DrawTexture(new Rect(0, 0 , Screen.width, 50), BarraEncabezadoAplicacion, ScaleMode.StretchToFill, true, 10.0F);

		}

		public void OnStateLevelLoad (int level)
		{
			this.BarraEncabezadoAplicacion = manager.gameDataRef.BarraEncabezadoAplicacion;
		}

	}
}

