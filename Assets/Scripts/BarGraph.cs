using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BarGraph : MonoBehaviour {

	Image img;
	bool hoge =false;

	void Start () {
		img = GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(hoge == false){
			hoge = true;
			StartCoroutine("BarEmulate");
		}
	}

	IEnumerator BarEmulate(){
		img.fillAmount = Random.Range (0,1f);
		yield return new WaitForSeconds (Random.Range(0.025f,0.1f));
		hoge = false;
	}
}
