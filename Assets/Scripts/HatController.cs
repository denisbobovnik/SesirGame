using UnityEngine;
using System.Collections;

public class HatController : MonoBehaviour {

    public Camera cam;

	// Use this for initialization
	void Start () {
	    if(cam == null)
            cam = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 rawPosition = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 targetPosition = new Vector3(rawPosition.x, transform.position.y, 0);
        GetComponent<Rigidbody2D>().MovePosition(targetPosition);
	}
}