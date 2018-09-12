using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour {

    int loadedScene = 0;

	// Use this for initialization
	void Start () {
        loadedScene = SceneManager.GetActiveScene().buildIndex;
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(loadedScene);
            Debug.Log("Reloaded the scene");
        }
	}
}
