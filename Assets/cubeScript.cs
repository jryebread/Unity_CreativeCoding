using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeScript : MonoBehaviour {

    public float rotateSpeed = 1.0f;
    public Vector3 spinspeed = Vector3.zero;

    Vector3 spinAxis = new Vector3(0, 1, 0); //jhat vector as axis of rotation(up = jhat)

	// Use this for initialization
	void Start () {
        //this.transform.position = new Vector3(0, 5, 2); //give it a z value for amplitude of rotation
        spinspeed = new Vector3(Random.value, Random.value, Random.value);
        spinAxis = Vector3.up;
        spinAxis.x = (Random.value - Random.value) * .1f;

	}

    public void setSize(float size)
    {
       this.transform.localScale = new Vector3(size, size, size);
    }
	
	// Update is called once per frame
	void Update () {
        this.transform.Rotate(spinspeed);
        this.transform.RotateAround(Vector3.zero, spinAxis, rotateSpeed);
	}
}
