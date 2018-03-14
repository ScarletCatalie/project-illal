using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwap : MonoBehaviour {

    public DragMouseOrbit perspshift;

	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyUp(KeyCode.Space))
        {
           
            perspshift.enabled = !perspshift.enabled;
            GameObject.Find("CAMERA").transform.localPosition = new Vector3(-2.85f, 1.3f, 1.1f);
            GameObject.Find("CAMERA").transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 90f));

        }

    }
}
