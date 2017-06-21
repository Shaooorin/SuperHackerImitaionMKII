using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MessageA : MonoBehaviour {
	
	Text messaA;
	bool hoge = false;

	void Start () {
		messaA = GetComponent<Text> ();
	}

	void Update () {
		if(hoge == false){
			hoge = true;
			StartCoroutine("NonsenseCode");
		}
	}

	IEnumerator NonsenseCode(){
		messaA.text = (string)NumberUtils.GenerateNumbers((int)Random.Range(24,70));
//		messaA.text = (string)StringUtils.GeneratePassword(8);
//		yield return new WaitForSeconds (0.025f);
		yield return new WaitForSeconds (Random.Range(0.025f,1f));
		hoge = false;
	}
}
