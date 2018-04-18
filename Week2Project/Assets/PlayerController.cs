using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public Rigidbody2D Rigid;
    public float JumpForce;

    // Use this for initialization
    void Start () {


	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigid.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
        }

    }
}
