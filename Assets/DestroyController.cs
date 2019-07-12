using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyController : MonoBehaviour {
    //Unityちゃんのオブジェクト
    private GameObject unitychan;
    //Unityちゃんとオブジェクトの距離
    private float difference;
	// Use this for initialization
	void Start () {
        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");
        //Unityちゃんとオブジェクトのz座標の差を求める
        this.difference = unitychan.transform.position.z - this.transform.position.z;


		
	}
	
	// Update is called once per frame
	void Update () {
        if(this.transform.position.z +3 < this.unitychan.transform.position.z)
        {
            Destroy(this.gameObject);
        }
		
	}
}
