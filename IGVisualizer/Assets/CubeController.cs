using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour {

	//public string url = "https://docs.unity3d.com/uploads/Main/ShadowIntro.png";
	public string url;
	IEnumerator Start() {

		Texture2D tex;
		tex = new Texture2D(4, 4, TextureFormat.DXT1, false);

		WWW www = new WWW(url);
		yield return www;
		www.LoadImageIntoTexture(tex);
		GetComponent<Renderer>().material.mainTexture = tex;
	}
}