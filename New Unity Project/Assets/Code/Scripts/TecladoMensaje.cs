using UnityEngine;
using System.Collections;

public class TecladoMensaje : MonoBehaviour {

	public static RecibirMensaje modulo;

	void OnMouseDown ()
	{
		switch(gameObject.name)
		{
		case "GUI_pop_number0":
			modulo.EscribirEnModulo("0");
			break;

		case "GUI_pop_number1":
			modulo.EscribirEnModulo("1");
			break;

		case "GUI_pop_number2":
			modulo.EscribirEnModulo("2");
			break;

		case "GUI_pop_number3":
			modulo.EscribirEnModulo("3");
			break;

		case "GUI_pop_number4":
			modulo.EscribirEnModulo("4");
			break;

		case "GUI_pop_number5":
			modulo.EscribirEnModulo("5");
			break;

		case "GUI_pop_number6":
			modulo.EscribirEnModulo("6");
			break;

		case "GUI_pop_number7":
			modulo.EscribirEnModulo("7");
			break;

		case "GUI_pop_number8":
			modulo.EscribirEnModulo("8");
			break;

		case "GUI_pop_number9":
			modulo.EscribirEnModulo("9");
			break;
		}
	}
}
