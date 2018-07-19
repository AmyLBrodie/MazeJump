using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Agent : MonoBehaviour {

    public GameObject[] floorDest;
    public GameObject key;
    public GameObject particle;
    public TextMesh healT;
    private NavMeshAgent agent;
    private Vector3 position;
    private Vector3 destination;
    private Random rand;
    private int index;
    private int current;
    private int old;
    private float thresh;
    private int health;

    // Use this for initialization
    void Start () {
        agent = GetComponent<NavMeshAgent>();
        position = transform.position;
        destination = floorDest[0].transform.position;
        current = 0;
        index = 0;
        old = 0;
        agent.SetDestination(destination);
        thresh = 1.0f;
        health = 60;
        key.tag = "Key";
	}
	
	// Update is called once per frame
	void Update () {

        position = transform.position;
        healT.text = ""+health;
        if (agent.remainingDistance < thresh)
        {
            old = index;
            index = Random.Range(0, 19);
            while (index == current)
            {
                index = Random.Range(0, 19);
            }
            current = old;
            destination = floorDest[index].transform.position;
            agent.SetDestination(destination);
            
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Crystal")
        {
            if (health > 3)
            {
                health -= 3;
            }
            else
            {
                
                position = new Vector3(position.x, position.y+1, position.z);
                GameObject.Instantiate(particle, position, transform.rotation);
                GameObject.Instantiate(key,position,transform.rotation);
                GameObject.Destroy(this.gameObject);
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        
    }
}
