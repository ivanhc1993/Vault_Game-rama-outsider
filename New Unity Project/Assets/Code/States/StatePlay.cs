using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States
{
	public class StatePlay : InterfacesStados
	{
		private GameManager manager;
		private GUISkin mySkin;
		private int nivel;
		private int moduleActivo;
		private GameObject module;
		private List<GameObject> modulePrefabs;
		private DataPlayState dataPlayState;
		private GUITexture tecladoPrefabs;

		public StatePlay (GameManager managerRef)
		{
			manager = managerRef;
			if(Application.loadedLevelName != "Play")
				Application.LoadLevel("Play");
			
			mySkin = manager.gameDataRef.mySkin;
			
			nivel = manager.gameDataRef.nivel;
			moduleActivo = 0;
		}
		
		public void StateUpdate ()
		{
			
		}
		
		public void ShowIt ()
		{
			GUI.skin = mySkin;

			// Boton Que pasa a la vista de historial
			if(GUI.Button(new Rect(Screen.width * 0.6f, Screen.height * 0.9f,70, 20), "Historial"))
			{
				manager.SwitchState(new StateHist(manager));
			}
		}
		
		public void OnStateLevelLoad (int level)
		{
			tecladoPrefabs = GameObject.Find ("GUI_pop_numberPad").GetComponentInChildren<GUITexture>();
			dataPlayState = GameObject.Find ("DataPlayState").GetComponent<DataPlayState> ();

			tecladoPrefabs.pixelInset = new Rect (0f,528f, Screen.width * 0.13f,Screen.width * 0.13f);

			this.modulePrefabs = dataPlayState.modulePrefabs;
			// Aqui instanciamos el GUI_module_1(Clone)
			module = Object.Instantiate (modulePrefabs [CualEs()], modulePrefabs [CualEs()].transform.position, modulePrefabs [CualEs()].transform.rotation) as GameObject;

			TecladoMensaje.modulo = module.GetComponent<RecibirMensaje>();
		}
		
		private int CualEs ()
		{
			return 0;
		}
	}
}

