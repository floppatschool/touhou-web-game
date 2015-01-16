using UnityEngine;
using System.Collections;

[RequireComponent(typeof(BoxCollider2D))]
public class AyaMainBullet : BulletBase_Touhou {

	// Use this for initialization
	void Start () {
        //base.Start();
	}

	// Update is called once per frame
	void Update () {
        base.Update();
	}

    void FixedUpdate()
    {
        rigidbody2D.velocity = speed;
    }
}
