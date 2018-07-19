using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn0 : MonoBehaviour {

    private Vector3 respawn;
    private Vector3 originalForward;
    public GameObject death;

	// Use this for initialization
	void Start () {
        respawn = new Vector3(0, 2, 0);
        originalForward = this.GetComponent<Transform>().forward;

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Death")
        {
            this.GetComponent<Transform>().position = respawn;
            this.GetComponent<Transform>().forward = originalForward;
        }
    }
}
