using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

	// Use this for initialization
	void Start () {

        this.difference = unitychan.transform.position.z - this.transform.position.z;

    }

    // Update is called once per frame
    void Update()  ｛

        //  画面外に出たら破壊する

        // if (transform.position.z　<　-5.0f)
        if (transform.position.z  <  -10.0f) ;

                                         

        {
            Destroy(gameObject);

        }

    }

    }

