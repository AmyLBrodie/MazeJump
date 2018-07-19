using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    private AudioSource keySound;
    private AudioSource crystSound;
    private float speed = 10.0f;
    private float jumpSpeed = 200.0f;



    // Use this for initialization

    void Start()
    {


    }



    // Update is called once per frame

    void Update()
    {

        if (Input.GetKey(KeyCode.W))

        {

            transform.position += transform.forward * Time.deltaTime * speed;

        }

        if (Input.GetKey(KeyCode.A))

        {

            //transform.position -= transform.right * Time.deltaTime * speed;
            transform.Rotate(transform.rotation.x, transform.rotation.y - 2.0f, transform.rotation.z);

        }

        if (Input.GetKey(KeyCode.D))

        {

            //transform.position += transform.right * Time.deltaTime * speed;
            transform.Rotate(transform.rotation.x, transform.rotation.y + 2.0f, transform.rotation.z);

        }

        if (Input.GetKey(KeyCode.S))

        {

            transform.position -= transform.forward * Time.deltaTime * speed;

        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += transform.up * Time.deltaTime * speed;
        }



    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Crystal")
        {
            crystSound = other.gameObject.GetComponent<AudioSource>();
            crystSound.Play();
            other.gameObject.GetComponent<MeshRenderer>().enabled = false;
            other.gameObject.GetComponent<MeshCollider>().enabled = false;
            GameObject.Destroy(other.gameObject,0.2f);
            Collectables.numCrystals += 1;
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Key")
        {
            keySound = collision.gameObject.GetComponent<AudioSource>();
            keySound.Play();
            collision.gameObject.GetComponent<MeshRenderer>().enabled = false;
            collision.gameObject.GetComponent<MeshCollider>().enabled = false;
            GameObject.Destroy(collision.gameObject,0.4f);
            Collectables.numKeys += 1;
        }
    }
}
