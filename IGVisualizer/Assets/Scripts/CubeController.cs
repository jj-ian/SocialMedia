using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class CubeController : MonoBehaviour {

	//public string url = "https://docs.unity3d.com/uploads/Main/ShadowIntro.png";
	public string url;
	//string json = "{\"level\":88}";
	//string json =  {"kiva":[{"ProductID":"OBR","ProductName":"Organic Brown Rice","ProductPrice":"1.11"},{"ProductID":"OWR","ProductName":"Organic White Rice","ProductPrice":"2.22"},{"ProductID":"NBR","ProductName":"Non Organic Brown Rice","ProductPrice":"3.33"},{"ProductID":"NWR","ProductName":"Non Organic White Rice","ProductPrice":"4.44"}]}
	
	//string json =  @"{""kiva"":[{""ProductID"":""OBR"",""ProductName"":""Organic Brown Rice"",""ProductPrice"":""1.11""},{""ProductID"":""OWR"",""ProductName"":""Organic White Rice"",""ProductPrice"":""2.22""},{""ProductID"":""NBR"",""ProductName"":""Non Organic Brown Rice"",""ProductPrice"":""3.33""},{""ProductID"":""NWR"",""ProductName"":""Non Organic White Rice"",""ProductPrice"":""4.44""}]}";
	/*string json = @"{
    ""status"": ""ok"", 
    ""more_available"": true, 
    ""items"": [
        {
            ""user"": {
                ""profile_picture"": ""https://scontent.cdninstagram.com/t51.2885-19/11856843_1606402006293534_1197670550_a.jpg"", 
                ""id"": ""233880922"", 
                ""full_name"": ""pre_war_post_bac"", 
                ""username"": ""pre_war_post_bac""
            }, 
            ""created_time"": ""1484181578"", 
            ""user_has_liked"": false, 
            ""id"": ""1425740875862672074_233880922"", 
            ""location"": {
                ""name"": ""Shoufong Township""
            }, 
            ""link"": ""https://www.instagram.com/p/BPJP8XPjILK/"", 
            ""code"": ""BPJP8XPjILK"", 
            ""can_delete_comments"": true, 
            ""caption"": {
                ""from"": {
                    ""profile_picture"": ""https://scontent.cdninstagram.com/t51.2885-19/11856843_1606402006293534_1197670550_a.jpg"", 
                    ""id"": ""233880922"", 
                    ""full_name"": ""pre_war_post_bac"", 
                    ""username"": ""pre_war_post_bac""
                }, 
                ""created_time"": ""1484181578"", 
                ""id"": ""17868415159060808"", 
                ""text"": ""#hualien is so beautiful... those are #egrets on the shore on the left #latergram #taiwan""
            }, 
            ""can_view_comments"": true, 
            ""images"": {
                ""thumbnail"": {
                    ""height"": 150, 
                    ""width"": 150, 
                    ""url"": ""https://scontent.cdninstagram.com/t51.2885-15/s150x150/e35/15802074_1013150938791249_7091379184840212480_n.jpg""
                }, 
                ""standard_resolution"": {
                    ""height"": 640, 
                    ""width"": 640, 
                    ""url"": ""https://scontent.cdninstagram.com/t51.2885-15/s640x640/sh0.08/e35/15802074_1013150938791249_7091379184840212480_n.jpg""
                }, 
                ""low_resolution"": {
                    ""height"": 320, 
                    ""width"": 320, 
                    ""url"": ""https://scontent.cdninstagram.com/t51.2885-15/s320x320/e35/15802074_1013150938791249_7091379184840212480_n.jpg""
                }
            }, 
            ""comments"": {
                ""data"": [ ], 
                ""count"": 0
            }, 
            ""likes"": {
                ""data"": [
                    {
                        ""profile_picture"": ""https://scontent.cdninstagram.com/t51.2885-19/11324355_509057125926804_468203000_a.jpg"", 
                        ""id"": ""358634032"", 
                        ""full_name"": ""Kalau Almony"", 
                        ""username"": ""kalau_almony""
                    }, 
                    {
                        ""profile_picture"": ""https://scontent.cdninstagram.com/t51.2885-19/11085003_362542123947816_1882598009_a.jpg"", 
                        ""id"": ""1693802164"", 
                        ""full_name"": ""Michelle Ngo"", 
                        ""username"": ""xomichellengo""
                    }, 
                    {
                        ""profile_picture"": ""https://scontent.cdninstagram.com/t51.2885-19/11192686_373129226220596_1976110885_a.jpg"", 
                        ""id"": ""796475"", 
                        ""full_name"": ""evan c"", 
                        ""username"": ""wheat_thins""
                    }, 
                    {
                        ""profile_picture"": ""https://scontent.cdninstagram.com/t51.2885-19/s150x150/15056664_674135946097143_1178649479696351232_a.jpg"", 
                        ""id"": ""51770680"", 
                        ""full_name"": ""chanelle"", 
                        ""username"": ""chanlldms""
                    }
                ], 
                ""count"": 28
            }, 
            ""type"": ""image"", 
            ""alt_media_url"": null
        }, 
        {
            ""user"": {
                ""profile_picture"": ""https://scontent.cdninstagram.com/t51.2885-19/11856843_1606402006293534_1197670550_a.jpg"", 
                ""id"": ""233880922"", 
                ""full_name"": ""pre_war_post_bac"", 
                ""username"": ""pre_war_post_bac""
            }, 
            ""created_time"": ""1483836281"", 
            ""user_has_liked"": false, 
            ""id"": ""1422844315659166003_233880922"", 
            ""location"": {
                ""name"": ""花蓮蝴蝶谷溫泉渡假村""
            }, 
            ""link"": ""https://www.instagram.com/p/BO-9V3VjGEz/"", 
            ""code"": ""BO-9V3VjGEz"", 
            ""can_delete_comments"": true, 
            ""caption"": {
                ""from"": {
                    ""profile_picture"": ""https://scontent.cdninstagram.com/t51.2885-19/11856843_1606402006293534_1197670550_a.jpg"", 
                    ""id"": ""233880922"", 
                    ""full_name"": ""pre_war_post_bac"", 
                    ""username"": ""pre_war_post_bac""
                }, 
                ""created_time"": ""1483836281"", 
                ""id"": ""17857116301091721"", 
                ""text"": ""who is she? #hualien #butterflyvalley #taiwan""
            }, 
            ""can_view_comments"": true, 
            ""images"": {
                ""thumbnail"": {
                    ""height"": 150, 
                    ""width"": 150, 
                    ""url"": ""https://scontent.cdninstagram.com/t51.2885-15/s150x150/e35/15876476_582850578583410_1911393586411208704_n.jpg""
                }, 
                ""standard_resolution"": {
                    ""height"": 640, 
                    ""width"": 640, 
                    ""url"": ""https://scontent.cdninstagram.com/t51.2885-15/s640x640/sh0.08/e35/15876476_582850578583410_1911393586411208704_n.jpg""
                }, 
                ""low_resolution"": {
                    ""height"": 320, 
                    ""width"": 320, 
                    ""url"": ""https://scontent.cdninstagram.com/t51.2885-15/s320x320/e35/15876476_582850578583410_1911393586411208704_n.jpg""
                }
            }, 
            ""comments"": {
                ""data"": [ ], 
                ""count"": 0
            }, 
            ""likes"": {
                ""data"": [
                    {
                        ""profile_picture"": ""https://scontent.cdninstagram.com/t51.2885-19/11327379_397231497139942_1514534957_a.jpg"", 
                        ""id"": ""247864569"", 
                        ""full_name"": ""Marie"", 
                        ""username"": ""tanahakaloogie""
                    }, 
                    {
                        ""profile_picture"": ""https://scontent.cdninstagram.com/t51.2885-19/s150x150/14733695_1798331580401710_8659232132679335936_a.jpg"", 
                        ""id"": ""194845650"", 
                        ""full_name"": ""Audrey Ellis Fox"", 
                        ""username"": ""audreyisgod""
                    }, 
                    {
                        ""profile_picture"": ""https://scontent.cdninstagram.com/t51.2885-19/s150x150/16585471_394031914291510_5234574083005349888_a.jpg"", 
                        ""id"": ""1776881908"", 
                        ""full_name"": ""Emma Chou"", 
                        ""username"": ""emma0211ww""
                    }, 
                    {
                        ""profile_picture"": ""https://scontent.cdninstagram.com/t51.2885-19/s150x150/12729445_486965884837514_1508552610_a.jpg"", 
                        ""id"": ""927585"", 
                        ""full_name"": ""Hui Jin (alex)"", 
                        ""username"": ""junchoooon""
                    }
                ], 
                ""count"": 9
            }, 
            ""type"": ""image"", 
            ""alt_media_url"": null
        }
    ]
}";
*/

		IEnumerator Start() {
		/*
		Debug.Log (json);
		Texture2D tex;
		tex = new Texture2D(4, 4, TextureFormat.DXT1, false);

		WWW www = new WWW(url);
		yield return www;
		www.LoadImageIntoTexture(tex);
		GetComponent<Renderer>().material.mainTexture = tex;
		*/
		/*
		groceryData data = JsonUtility.FromJson<groceryData> (json);
		Debug.Log (data.kiva.Count);
		Debug.Log (data.kiva [1]);
		foreach (groceryObject tes in data.kiva) {
			Debug.Log (tes.ProductID + tes.ProductPrice + tes.ProductName);
		}*/
		url = "https://www.instagram.com/pre_war_post_bac/media/";
		WWW www = new WWW (url);
		yield return www;
		string json = www.text;
		topLevelData data = JsonUtility.FromJson<topLevelData> (json);
		Debug.Log (data.status);
		Debug.Log (data.more_available);
		foreach (itemData item in data.items) {
			Debug.Log (item.id);
		}
	}
	
	[System.Serializable]
	/*
	public struct groceryObject 
	{
	public string ProductID;
	public string ProductName;
	public int ProductPrice;
	}*/
	public struct topLevelData
	{
		public string status;
		public bool more_available;
		public List<itemData> items;
	}

	[System.Serializable]
	public class itemData{
		public string id;
	}
		

	/*
	public class topLevelData 
	{
		public List<groceryObject> kiva;
	}*/
	/*
	public class groceryData 
	{
		public List<groceryObject> kiva;
	}*/
}