using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn1 : MonoBehaviour {

    private Vector3 respawn;
    private Vector3 originalForward;
    public GameObject death;

    // Use this for initialization
    void Start () {
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Respawn")
        {
            respawn = other.gameObject.GetComponentInParent<Transform>().position;
            originalForward = new Vector3(this.GetComponent<Transform>().forward.x,0, this.GetComponent<Transform>().forward.z);
            this.GetComponent<Transform>().forward = originalForward;
        }
    }
}
