using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject view;

    float mouseWheel;
    //bool leftClick;

	// Use this for initialization
	void Start () {
        mouseWheel = Input.GetAxis("Mouse ScrollWheel");
        //leftClick = Input.GetButton("Fire1");
    }
	
	// Update is called once per frame
	void Update () {
		if (mouseWheel > 0f)
        {
            Debug.Log("Going up");
            view.transform.position = new Vector3(view.transform.position.x, view.transform.position.y + 1,0f);
        }
        else if (mouseWheel < 0f)
        {
            Debug.Log("Going down");
            view.transform.position = new Vector3(view.transform.position.x, view.transform.position.y - 1, 0f);
        }
    }
}
