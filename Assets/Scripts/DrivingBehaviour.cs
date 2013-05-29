using UnityEngine;
using System.Collections;

public class DrivingBehaviour : MonoBehaviour {
	public float SteeringAngle = 2.5f;
	public float DrivingSpeed = 1.0f;
	public string SteeringAxis = "Horizontal";
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.gameObject.transform.RotateAroundLocal(Vector3.up, SteeringAngle * Input.GetAxis(SteeringAxis) * Time.deltaTime);
		this.gameObject.transform.Translate(Vector3.forward * DrivingSpeed * Time.deltaTime);
	}
}
