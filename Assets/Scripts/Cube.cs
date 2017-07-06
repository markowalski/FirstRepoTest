using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
	    	
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 pos = transform.position;
        transform.position = new Vector3(pos.x + Random.value * .1f, pos.y + Random.value * .1f, pos.z);
    }
}
