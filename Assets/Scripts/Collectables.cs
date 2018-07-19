using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectables : MonoBehaviour {

    public Text crystalScore;
    public Text keyScore;

    public static int numCrystals;
    public static int totalCrystals;
    public static int numKeys;
    public static int totalKeys;

    // Use this for initialization
    void Start () {
        numCrystals = 0;
        numKeys = 0;
        totalCrystals = 60;
        totalKeys = 3;
	}
	
	// Update is called once per frame
	void Update () {
        keyScore.text = "Keys: " + numKeys + "/" + totalKeys;
        crystalScore.text = "Crystals: " + numCrystals + "/" + totalCrystals;
	}
}
