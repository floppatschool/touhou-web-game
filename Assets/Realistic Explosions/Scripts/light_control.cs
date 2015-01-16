using UnityEngine;
using System.Collections;

public class light_control : MonoBehaviour {
	private float t=0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		t+=Time.deltaTime;
		if (t>.5f){
	this.light.intensity+=(0f-this.light.intensity)/100f;
		}
	}
}
