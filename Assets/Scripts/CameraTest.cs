﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 pos = transform.position;
        Vector3 pos2 = transform.position;
        Vector3 pos3 = transform.position;
        transform.position = new Vector3(pos.x + .01f, pos.y, pos.z);
	}
}
