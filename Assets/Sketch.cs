using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sketch : MonoBehaviour {

    public GameObject myPrefab;

	// Use this for initialization
	void Start () {

        int totalCubes = 30;

        float totalDistance = 2.8f;

        //SIN DISTRO
        for (int i = 0; i < totalCubes; ++i)
        {
            float perc = i / (float)totalCubes; //perc goes from 0 to 1.0
            float sin = Mathf.Sin(perc * (Mathf.PI/2));

            float x = 0.0f;
            float y = 5.0f;
            float z = 1.5f + sin * totalDistance;

            var newCube = (GameObject)Instantiate(myPrefab, new Vector3(x, y, z), Quaternion.identity);

            newCube.GetComponent<cubeScript>().setSize(.45f * (1.0f - perc));
            newCube.GetComponent<cubeScript>().rotateSpeed = .2f + 4.0f*perc;
        }

    }

    // Update is called once per frame
    void Update () {
		
	}
}
