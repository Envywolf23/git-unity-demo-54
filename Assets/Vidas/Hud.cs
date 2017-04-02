using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Hud : MonoBehaviour {

    public Health Scripts;
    public GameObject Barra_Vida;
    private Animator anim;
    public const string ESTADO_VIDAS = "Vidas";
    
	// Use this for initialization
	void Start () {
        anim = Barra_Vida.GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {
        anim.SetInteger(ESTADO_VIDAS , Scripts.Vidas);
	}
}
