using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System;
using UnityEngine.Networking;
using System.Text;
using Newtonsoft.Json;

public class GameOverScript : MonoBehaviour 
{
	GameObject DataManager;
	SaveDataScript SDS;

	[SerializeField] TextMeshProUGUI ScoreText;
	[SerializeField] TextMeshProUGUI Reference;
	[SerializeField] Image imgReward;
	[SerializeField] GameObject LoadDataFailde;

	public static string imgReward_uri;

	int CurrentScore, HighScore;

	void Start () 
	{
		DataManager = GameObject.FindGameObjectWithTag ("DM");	
		SDS = DataManager.GetComponent<SaveDataScript> ();

		CurrentScore = SDS.CurrentScore;
		HighScore = SDS.GetHighScore ();

		ScoreText.text = "Score : " + CurrentScore.ToString ();

		if (CurrentScore > HighScore) 
		{
			HighScore = CurrentScore;

			SDS.SetHighScore (CurrentScore);
			SDS.Save ();
		}
		//BestScoreText.text = "Best : " + HighScore.ToString ();
		Reference.text = "REF : " + Ricimi.GetData.checkCode;
		StartCoroutine(MakeRequests());
	}
	private IEnumerator MakeRequests()
	{
		//yield return new WaitForSeconds(2);
		// POST
		var dataToPost = new PostData() { gamecode = Ricimi.GetData.checkCode, ref_code = Remote_Config.ID, score = CurrentScore.ToString() };
		var postRequest = CreateRequest(Remote_Config.URL_Api_SetReward, RequestType.POST, dataToPost);
		yield return postRequest.SendWebRequest();
		PostResult img = JsonConvert.DeserializeObject<PostResult>(postRequest.downloadHandler.text);
		imgReward_uri = img.imgReward;

		string uri = imgReward_uri;
		using (UnityWebRequest request = UnityWebRequestTexture.GetTexture(uri))
		{
			yield return request.SendWebRequest();
			if (request.result == UnityWebRequest.Result.ProtocolError || request.result == UnityWebRequest.Result.ConnectionError)
            {
				LoadDataFailde.SetActive(true);
				//Debug.Log(request.error);
			}
			else
			{
				Texture2D texture2D = ((DownloadHandlerTexture)request.downloadHandler).texture;
				Sprite sprite = Sprite.Create(texture2D, new Rect(0, 0, texture2D.width, texture2D.height), new Vector2(0.5f, 0.5f));

				imgReward.sprite = sprite;
			}
		}
	}

	private UnityWebRequest CreateRequest(string path, RequestType type = RequestType.GET, object data = null)
	{
		var request = new UnityWebRequest(path, type.ToString());
		if (data != null)
		{
			var bodyRaw = Encoding.UTF8.GetBytes(JsonUtility.ToJson(data));
			request.uploadHandler = new UploadHandlerRaw(bodyRaw);
		}
		request.downloadHandler = new DownloadHandlerBuffer();
		request.SetRequestHeader("Content-Type", "application/json");
		return request;
	}

	private void AttachHeader(UnityWebRequest request, string key, string value)
	{
		request.SetRequestHeader(key, value);
	}

	public void Play()
	{
		Time.timeScale = 1;
		SceneManager.LoadScene (2);
	}

	public void MainMenu () 
	{
		Time.timeScale = 1;
		SceneManager.LoadScene (1);
	}
}
public enum RequestType
{
	GET = 0,
	POST = 1,
	PUT = 2
}


public class Todo
{
	public int userId;
	public int id;
	public string title;
	public bool completed;
}

[Serializable]
public class PostData
{
	public string id;
	public string CustomerName;
	public string gamecode;
	public string ref_code;
	public string create_date;
	public string score;
}

public class PostResult
{
	public string qrcode { get; set; }
	public string imgReward { get; set; }
	public string logo_cobiz19 { get; set; }
	public string Background_main { get; set; }
	public string Background_qr { get; set; }
	public string Background_null { get; set; }
	public string Background_Alert_error { get; set; }
	public string Background_Alert_succes { get; set; }
	public string Background_Button_tap { get; set; }
	public string Background_thank { get; set; }
	public string Background_Button_home { get; set; }
}
