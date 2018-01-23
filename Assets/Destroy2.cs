using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {

        //  画面外に出たら破壊する


        if (transform.position.z < -10.0f) 

            
        {
            Destroy(gameObject) ;

        }
    }
}
