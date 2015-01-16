using UnityEngine;
using System.Collections;

public class smoky_explosion : MonoBehaviour {
	private float t1=0f;
	private float t=0f;
	public float delay = 0f;
	private bool expl=false;
	public float force_k=1f;
	// Use this for initialization
	void explo () {
		expl=true;
	//this.transform.eulerAngles = new Vector3(Random.Range(-50f,-85f),Random.Range(-180f,180f),0f);
		this.rigidbody.AddRelativeForce(Vector3.forward*200f*force_k*Random.Range(.9f,1.1f));
	}
	
	// Update is called once per frame
	void Update () {
	
	t1+=Time.deltaTime;
	if (t1>=delay){	
			t+=Time.deltaTime;
	if (t>.2f){
			print (this.particleSystem.startSize);	
			this.particleSystem.startSize+=(0f-this.particleSystem.startSize)/30f;
			this.particleSystem.startColor+=(new Color(this.particleSystem.startColor.r,this.particleSystem.startColor.g,this.particleSystem.startColor.b,0f)-this.particleSystem.startColor)/10f;
		}	
		if (t>7f){
			Destroy(this.gameObject);
			
		}
	}
	}
	void FixedUpdate(){
		if (t1>=delay){	
			if (!expl)
			{
				explo ();
			}
		//this.rigidbody.AddForce(-Vector3.up/4f);
		}
	}
}
