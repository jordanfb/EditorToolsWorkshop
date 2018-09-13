using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MarbleScript : MonoBehaviour {

    [SerializeField]
    private MarbleInformation info;

    [Space]
    [Space]
    [Header("This is the section on colors")]
    [SerializeField]
    private Color marbleColor;
    [HideInInspector]
    public Color donteditthis;

	// Use this for initialization
	void Start () {
        transform.localScale = info.marbleRadius * Vector3.one;
        GetComponent<Rigidbody2D>().gravityScale = info.gravityScalar;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
