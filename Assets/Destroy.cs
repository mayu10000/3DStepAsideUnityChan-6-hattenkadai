using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

    // private object unitychan;

    public GameObject unitychan;


    public float difference { get; private set; }


    // Use this for initialization
    void Start () {

        this.difference = unitychan.transform.position.z - this.transform.position.z;

        // this.unitychan = GameObject.Find("unitychan");

        unitychan = GameObject.Find("unitychan");

    }

    // Update is called once per frame
    void Update() {

        // this.difference = unitychan.transform.position.z - this.transform.position.z;

        // this.gameObject.transform.position < 10
        //   this.difference = unitychan.transform.position.z - this.transform.position.z;


        // this.difference = unitychan.transform.position.z - this.transform.position.z;

        //  画面外に出たら破壊する

        // if (transform.position.z　<　-5.0f)
        //  if (transform.position.z  <  this.difference

        // if (gameObject.transform.position.z =< (unitychan.transform.position.z - this.transform.position.z))

        //if (gameObject.transform.position.z - this.transform.position.z） >= (unitychan.transform.position.z - this.transform.position.z))

        // if (gameObject.transform.position.z - transform.position.z）= > (unitychan.transform.position.z - transform.position.z))

        // if (gameObject.transform.position.z - transform.position.z）= < (unitychan.transform.position.z - 10.0f)


        

        if (unitychan.transform.position.z - gameObject.transform.position.z  >  10.0f)

                    {
            Destroy(gameObject);

        }

    }

    }

