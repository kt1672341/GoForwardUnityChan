using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
    //衝突時に呼ばれる関数
    void OnCollisionEnter2D(Collision2D other) {

        //オブジェクトに衝突した場合
        if (other.gameObject.tag == "blockTag") {


            GetComponent<AudioSource>().Play();
        }
    }
}


