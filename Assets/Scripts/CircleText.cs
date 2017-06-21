using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CircleText : MonoBehaviour {



	void Start () {
	}

	void Update () {
		transform.RotateAround (transform.parent.position,Vector3.forward,20f * Time.deltaTime);
	}

	void OnGui(){
	}
}
