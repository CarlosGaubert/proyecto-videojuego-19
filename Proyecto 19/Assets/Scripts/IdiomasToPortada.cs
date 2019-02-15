using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IdiomasToPortada : MonoBehaviour{


	public Animator anim;

	public void cambiaraportada(){
		anim = GetComponent<Animator>();
		anim.SetBool("cambiaraportada",true);
	} 

  
}
