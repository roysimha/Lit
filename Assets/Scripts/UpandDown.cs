﻿using UnityEngine;
using System.Collections;

public class UpandDown : MonoBehaviour {
    private float ylocation;
    public float ymax;
    private float ymin;
    public float rateOfAsscend;
	// Use this for initialization
	void Start () {
        ylocation = transform.position.y;
        ymin = ylocation -ymax;
        ymax = ylocation + ymax;
        rateOfAsscend *= Time.deltaTime;
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y > ymax || transform.position.y < ymin)
        {

            rateOfAsscend *= -1;
        }
        transform.Translate(new Vector3(0, rateOfAsscend, 0));
	}
}
