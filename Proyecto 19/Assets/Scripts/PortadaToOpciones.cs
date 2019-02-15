using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PortadaToOpciones : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim;

	public void cambiaraopciones(){
		anim = GetComponent<Animator>();
		anim.SetBool("cambiaraopciones",true);
	} 
}
