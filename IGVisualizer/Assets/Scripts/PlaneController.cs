// Add this script to a GameObject. The Start() function fetches an
// image from the documentation site.  It is then applied as the
// texture on the GameObject.

using UnityEngine;
using System.Collections;

public class PlaneController : MonoBehaviour {

	public string url = "https://docs.unity3d.com/uploads/Main/ShadowIntro.png";

	IEnumerator Start() {

		Texture2D tex;
		tex = new Texture2D(4, 4, TextureFormat.DXT1, false);
		WWW www = new WWW(url);
		yield return www;
		www.LoadImageIntoTexture(tex);
		GetComponent<Renderer>().material.mainTexture = tex;
	}
}