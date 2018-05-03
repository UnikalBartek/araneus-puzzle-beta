using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceMagnet : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log(collision.name + " magneted by: " + this.name);
        collision.GetComponent<Transform>().position = (new Vector3(this.transform.position.x, this.transform.position.y, collision.transform.position.z));
    }

    // Update is called once per frame
    void Update () {
		
	}
}
