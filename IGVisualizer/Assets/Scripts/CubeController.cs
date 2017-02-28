using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class CubeController : MonoBehaviour {

	//public string url = "https://docs.unity3d.com/uploads/Main/ShadowIntro.png";
	public string url;

		IEnumerator Start() {

		url = "https://www.instagram.com/pre_war_post_bac/media/";
		WWW www = new WWW (url);
		yield return www;
		string json = www.text;
		topLevelData data = JsonUtility.FromJson<topLevelData> (json);
		Debug.Log (data.status);
		Debug.Log (data.more_available);
		foreach (items item in data.items) {
			string imgURL = item.images.low_resolution.url;
			Debug.Log (imgURL);

			Texture2D tex;
			tex = new Texture2D(4, 4, TextureFormat.DXT1, false);
			WWW wwwImg = new WWW (imgURL);
			yield return wwwImg;

			wwwImg.LoadImageIntoTexture(tex);
			GetComponent<Renderer>().material.mainTexture = tex;

		}
	
	}
	
	[System.Serializable]

	public struct topLevelData
	{
		public string status;
		public bool more_available;
		public List<items> items;
	}

	[System.Serializable]
	public class items{
		public string id;
		public images images;

	}
	[System.Serializable]
	public class images{
		public lowResolution low_resolution;

	}
	[System.Serializable]
	public class lowResolution {
		public int height;
		public int width;
		public string url;

	}
		
}