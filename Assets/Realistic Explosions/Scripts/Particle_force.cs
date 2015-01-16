using UnityEngine;
using System.Collections;

public class Particle_force : MonoBehaviour {
	private float t=0f;
	// Use this for initialization
	void Start () {
	this.transform.eulerAngles = new Vector3(Random.Range(-40f,-60f),Random.Range(-180f,180f),0f);
		this.rigidbody.AddRelativeForce(Vector3.forward*20f*Random.Range(.75f,1.5f));
	}
	
	// Update is called once per frame
	void Update () {
	t+=Time.deltaTime;
	if (t>1f){
			this.particleSystem.startSize+=(0f-this.particleSystem.startSize)/30f;
			this.particleSystem.startColor+=(new Color(this.particleSystem.startColor.r,this.particleSystem.startColor.g,this.particleSystem.startColor.b,0f)-this.particleSystem.startColor)/10f;
		}	
		if (t>2f){
			Destroy(this.gameObject);
			
		}
	}
	
	void FixedUpdate(){
		this.rigidbody.AddForce(-Vector3.up/4f);
		
	}
}
