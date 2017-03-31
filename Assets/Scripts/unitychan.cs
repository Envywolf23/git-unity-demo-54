using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Rigidbody))]
public class unitychan : MonoBehaviour {
	
	public Animator anim;
	public Rigidbody rbody;
	private float inputH;
	private float inputV;

	// Use this for initialization
	void Start () {

		anim = GetComponent<Animator> ();
		rbody = GetComponent<Rigidbody> ();

	
	}
	
	// Update is called once per frame
	void Update () {
		
		inputH = Input.GetAxis ("Horizontal");
		inputV = Input.GetAxis ("Vertical");

		anim.SetFloat("inputH",inputH);
		anim.SetFloat("inputV",inputV);

		float moveX = inputH*70f*Time.deltaTime;
		float moveZ = inputV*100f*Time.deltaTime;

	

	
		}
	
	}

