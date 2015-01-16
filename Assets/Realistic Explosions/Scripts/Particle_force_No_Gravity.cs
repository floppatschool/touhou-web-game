using UnityEngine;
using System.Collections;

public class Particle_force_No_Gravity : MonoBehaviour {
	private float t=0f;
	// Use this for initialization
	void Start () {
	this.transform.eulerAngles = new Vector3(Random.Range(-90f,90f),Random.Range(-180f,180f),0f);
		this.rigidbody.AddRelativeForce(Vector3.forward*30f);
	}
	
	// Update is called once per frame
	void Update () {
	t+=Time.deltaTime;
	if (t>1f){
			this.particleSystem.startSize+=(0f-this.particleSystem.startSize)/30f;
			this.particleSystem.startColor+=(new Color(this.particleSystem.startColor.r,this.particleSystem.startColor.g,this.particleSystem.startColor.b,0f)-this.particleSystem.startColor)/10f;
		}	
		if (t>2.5f){
			Destroy(this.gameObject);
			
		}
	}
}
