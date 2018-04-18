using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animController : MonoBehaviour {

    /// <summary>
    /// Providing Animation to a cube
    /// </summary>
    public Animator Anim;//call the variable Anim as a Animator
    
	// Use this for initialization
	void Start ()
    {
        Anim = GetComponent<Animator>(); //declearing the anim as a animator
    }
    
	// Update is called once per frame
	void Update ()
    {
        Anim.Play("CubeAnimation"); //calling the bool for the animation

    }

    private void OnDisable()
    {
        Application.Quit();
    }
}
