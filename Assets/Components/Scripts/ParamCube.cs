﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParamCube : MonoBehaviour
{
    public int band;
    public float startScale;
    public float scale;

	void Start ()
    {
		
	}
	
	void Update ()
    {
        transform.localScale = new Vector3(transform.localScale.x, AudioPeer.frequencyBand[band] * scale + startScale, transform.localScale.z);
	}
}