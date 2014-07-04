using System;
using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States
{
	public class StateHist : InterfacesStados
	{
		private GameManager manager;
		private GUISkin mySkin;

		// Texturas
		private Texture imagenReloj;
		private Texture termometro;

		// Variable que indica la posicion en Y de los iconos de tienda, datos, panel y temporizador.
		private float positionY;
		// Variable que indica el espacio entre botones.
		private float distanciaEntreBotones;
		private float posicionXTienda;
		private float posicionXEstadistica;
		private float posicionXPanel;
		private float posicionXTermometro;
		private Vector2 scrollPosition;
		private float vertScrollPosition;

		public StateHist (GameManager managerRef)
		{
			manager = managerRef;
			if(Application.loadedLevelName != "Hist")
				Application.LoadLevel("Hist");

			this.mySkin = manager.gameDataRef.mySkin;
		}

		public void StateUpdate ()
		{
			positionY = Screen.height - ((Screen.width * 0.17f)+ Screen.width * 0.03f);
			posicionXTienda = ((Screen.width * 0.17f) + distanciaEntreBotones);
			distanciaEntreBotones = Screen.width * 0.025f;
			posicionXEstadistica = Screen.width * 0.17f + distanciaEntreBotones + posicionXTienda;
			posicionXPanel = Screen.width * 0.14f + distanciaEntreBotones + posicionXEstadistica;
			posicionXTermometro = Screen.width * 0.27f + distanciaEntreBotones;

		}

		public void ShowIt ()
		{
			GUI.skin = mySkin;

			if(GUI.Button(new Rect(Screen.height * 0.01f, Screen.height * 0.03f, 20, 20), new GUIContent("", "Click para salir"), "buttonClose"))
			{
				manager.SwitchState(new StateHome(manager));
			}

			//Este boton me permite entrar a la pantala de tienda
			if(GUI.Button(new Rect(Screen.width - Screen.width * 0.17f - distanciaEntreBotones, positionY, Screen.width * 0.17f, Screen.width * 0.17f), "Tienda", "buttonStore"))
			{
				manager.SwitchState(new StateStore(manager));
			}

			//Este boton me permite entrar a la pantala de cupones 50%
			if(GUI.Button(new Rect(Screen.width - posicionXEstadistica, positionY, Screen.width * 0.18f, Screen.width * 0.17f), "", "buttonCup"))
			{
				manager.SwitchState(new StateCupon(manager));
			}

			//Este boton me permite entrar a la pantala de Panel
			if(GUI.Button(new Rect(Screen.width - posicionXPanel, positionY - Screen.width * 0.015f, Screen.width * 0.15f, Screen.width * 0.20f), "", "buttonPanel"))
			{
				manager.SwitchState(new StatePlay(manager));
			}

			scrollPosition = GUI.BeginScrollView (new Rect(Screen.width * 0.05F, Screen.height * 0.20F, Screen.width * 0.45F, Screen.height * 0.60F), 
			                                     scrollPosition, new Rect(0, 0, Screen.width * 0.4F, Screen.height * 3));

				GUI.DrawTexture (new Rect(0, 0, Screen.width * 0.4F, 100), termometro);

			GUI.EndScrollView ();

			//Textura de Reloj
			GUI.DrawTexture (new Rect (Screen.width - (posicionXPanel + Screen.width * 0.42f), positionY, Screen.width * 0.4f, Screen.width * 0.17f), imagenReloj, ScaleMode.StretchToFill, true, 10.0F);

			//Textura de termometro
			GUI.DrawTexture (new Rect (Screen.width - posicionXTermometro, Screen.height * 0.24f, Screen.width * 0.21f, Screen.height * 0.52f), termometro, ScaleMode.StretchToFill, true, 10.0F);
		}

		public void OnStateLevelLoad (int level)
		{
			this.imagenReloj = manager.gameDataRef.imagenReloj;
			this.termometro = manager.gameDataRef.termometro;

		}

	}
}

