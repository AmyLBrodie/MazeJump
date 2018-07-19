using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour {

    private bool keyCheck;
    private bool crystalCheck;
    private bool gameOver;

	// Use this for initialization
	void Start () {
        keyCheck = false;
        crystalCheck = false;
        gameOver = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Collectables.numKeys >= Collectables.totalKeys)
        {
            keyCheck = true;
        }

        if (Collectables.numCrystals >= Collectables.totalCrystals)
        {
            crystalCheck = true;
        }

        if (gameOver)
        {
            SceneManager.LoadScene(2);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Gate")
        {
            if (keyCheck && crystalCheck)
            {
                gameOver = true;
            }
        }
    }
}
