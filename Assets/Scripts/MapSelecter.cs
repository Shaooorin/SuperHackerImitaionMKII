using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MapSelecter : MonoBehaviour {

	Image img;
	string[] imagePath = new string[]{
		"bluePrint01",
		"bluePrint02",
		"bluePrint03",
		"bluePrint05"
	};

	bool hoge = false;

	void Start () {
		img = GameObject.Find("Canvas/Window002/Mapper").GetComponent<Image>();
	}

	void Update () {
		if(hoge == false){
			hoge = true;
			StartCoroutine("MapImage");
		}
	}

	IEnumerator MapImage(){
		int n = Random.Range (0,imagePath.Length);
		Texture2D texture = Resources.Load(imagePath[n]) as Texture2D;
		img.sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.zero);
		yield return new WaitForSeconds (Random.Range(1f,5f));
		hoge = false;
	}
}
