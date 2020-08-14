using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallShooter : MonoBehaviour {
    // textオブジェクト参照用
    GameObject textObject;

    // Textコンポーネント参照用
    Text scoreText;

    void Start () {
        // 初速, 角度
        float INIT_SPEED = 20f;
		float INIT_DEGREE = 60f;

        // Rigidbodyコンポーネントへの参照を取得
        Rigidbody rb = gameObject.GetComponent<Rigidbody>();

        // 初速を与える
        Vector3 vel = Vector3.zero;
        vel.y = INIT_SPEED;
		
		vel.x = INIT_SPEED*Mathf.Cos(INIT_DEGREE*Mathf.PI/180f);
		vel.y = INIT_SPEED*Mathf.Sin(INIT_DEGREE*Mathf.PI/180f);
		rb.velocity = vel;

        // Textオブジェクトの参照
        textObject = GameObject.Find("Text");

        // Textオブジェクトのコンポーネントを参照
        scoreText = textObject.GetComponent<Text>();
	}

    void FixedUpdate(){
        scoreText.text = "X：" + gameObject.transform.position.x.ToString();
    }

    void Update () {
		
    }
}
