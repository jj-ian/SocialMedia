/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

	//public string url = "http://localhost:8888/15802946_341588536226307_9177703001056346112_n.jpg";
	//public string url = "http://images.earthcam.com/ec_metros/ourcams/fridays.jpg";
	public string url = "https://upload.wikimedia.org/wikipedia/commons/4/47/PNG_transparency_demonstration_1.png";
	IEnumerator Start() {
		
		WWW www = new WWW(url);
		yield return www;
		//Debug.Log (www.text);
		Renderer renderer = GetComponent<Renderer>();
		renderer.material.mainTexture = www.texture;

		Texture2D tex;
		tex = new Texture2D(4, 4, TextureFormat.DXT1, false);
		WWW www = new WWW(url);
		yield return www;
		www.LoadImageIntoTexture(tex);
		GetComponent<Renderer>().material.mainTexture = tex;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
*/
// Add this script to a GameObject. The Start() function fetches an
// image from the documentation site.  It is then applied as the
// texture on the GameObject.

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