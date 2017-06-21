using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MessageB : MonoBehaviour {

	Text messaB;
	bool hoge = false;

	void Start () {
		messaB = GetComponent<Text> ();
	}

	void Update () {
		if(hoge == false){
			hoge = true;
			StartCoroutine("NonsenseCode");
		}
	}

	IEnumerator NonsenseCode(){
		messaB.text = (string)StringUtils.GeneratePassword((int)Random.Range(5,9));
//		messaB.text = (string)StringUtils.GeneratePassword(8);
//		yield return new WaitForSeconds (0.025f);
		yield return new WaitForSeconds (Random.Range(0.025f,0.055f));
		hoge = false;
	}
}
