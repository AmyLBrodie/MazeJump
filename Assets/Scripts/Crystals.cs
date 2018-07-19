using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystals : MonoBehaviour {

    public GameObject[] crystals;
    public GameObject crystalMesh;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        for (int i = 0; i < crystals.Length; i++)
        {
            crystals[i].GetComponentInChildren<Transform>().Rotate(Vector3.up * Time.deltaTime * 45);
        }
    }
}
