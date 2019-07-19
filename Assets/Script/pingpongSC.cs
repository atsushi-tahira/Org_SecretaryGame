using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pingpongSC : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.localScale = new Vector2(Mathf.PingPong(2, 3), transform.localScale.y);


    }
}
