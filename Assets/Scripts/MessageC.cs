using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MessageC : MonoBehaviour {

	Text messaC;
	bool hoge = false;

	void Start () {
		messaC = GetComponent<Text> ();
	}

	void Update () {
		if(hoge == false){
			hoge = true;
			StartCoroutine("NonsenseCode");
		}
	}

	IEnumerator NonsenseCode(){
//		messaA.text = (string)StringUtils.GeneratePassword((int)Random.Range(5,9));
		messaC.text = (string)NumberUtils.GenerateNumbers(Random.Range(12,42));
//		yield return new WaitForSeconds (0.025f);
		yield return new WaitForSeconds (Random.Range(0.025f,0.085f));
		hoge = false;
	}
}
