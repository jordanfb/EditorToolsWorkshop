using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleScript : MonoBehaviour {

    [SerializeField]
    private float gravityScalar;
    [SerializeField]
    private float radius;

	// Use this for initialization
	void Start () {
        transform.localScale = radius * Vector3.one;
        GetComponent<Rigidbody2D>().gravityScale = gravityScalar;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
