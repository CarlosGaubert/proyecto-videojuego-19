﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CambiarEscena : MonoBehaviour {

	public void CambiarEscena_(string escena){
		SceneManager.LoadScene (escena);
	}


	public void Salir(){
		Application.Quit ();
		print ("Saliendo");
	}

}
