using UnityEngine;
using Assets.Code.Interfaces;
using System.Collections;

public class GameData : MonoBehaviour {

	public string userName;
	public string password;
	public float musicVolume;
	public float soundFXVolume;
	public int nivel;
	public Texture imagenReloj;
	public Texture termometro;


	[HideInInspector]
	public string refAccount;
	[HideInInspector]
	public string phone;
	[HideInInspector]
	public string mail;

	//mySkin es la skin customizada que hize para la aplicacion
	public GUISkin mySkin;
	//private AudioClip pista;

	//Texturas2D para la pantalla de configuracion
	public Texture[] payMethod;

	//Texturas2D encabezado de la aplicacion
	public Texture BarraEncabezadoAplicacion;

	void Start ()
	{
		userName = "no user";
		musicVolume = 1;
		soundFXVolume = 1;
		refAccount = "xxx-xxxx-xxxx-xx";
		phone = "(xxx) xxx-xxxx";
		mail = "e.mail123@mail.com";
		nivel = 1;
		//pista = audio.clip;
	}

	void Update ()
	{
		audio.volume = musicVolume;	
	}
}
