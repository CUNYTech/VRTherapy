using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanges : MonoBehaviour {

    /// <summary>
    /// Color changes when the recticle is pointing to the object 
    /// </summary>

    public Material nolook; //declaring variables to both color changes
    public Material looking;

	// Use this for initialization
	void Start ()
    {
        GetComponent<Renderer>().material = nolook; //no action till pointed to the object
    }

    //function for looking at the object
    public void Sight()
    {
        GetComponent<Renderer>().material = looking; 
    }

    //function for not looking at the object
    public void Nosight()
    {
        GetComponent<Renderer>().material = nolook;
    }
}
