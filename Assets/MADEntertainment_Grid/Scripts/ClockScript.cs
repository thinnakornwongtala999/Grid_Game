
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using TMPro;
using Ricimi;

public class ClockScript : MonoBehaviour 
{

	[SerializeField]
	Sprite WhiteSprite;

	[SerializeField]
	TextMeshProUGUI ClockText;
	[SerializeField]
	TextMeshProUGUI WaitText;

	public int TimeLeft = 30;
	int Seconds = 6;

	public bool AllowTouch;
	bool TickTock;

	GameObject DataManager;
	SaveDataScript SDS;

	[SerializeField]
	GameObject GameManager;
	ScoreMgmt SMG;
	RandomiserScript RMS;
	//ThemeChangeScript CGS;

	public GameObject popupPrefab;

	protected Canvas m_canvas;

	void Start () 
	{
		m_canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
		DataManager = GameObject.FindGameObjectWithTag ("DM");
		SDS = DataManager.GetComponent<SaveDataScript> ();
		SMG = GameManager.GetComponent<ScoreMgmt> ();
		RMS = GameManager.GetComponent<RandomiserScript> ();
		//CGS = DataManager.GetComponent<ThemeChangeScript> ();

		//gameObject.GetComponent<SpriteRenderer> ().color = new Color32 (CGS.R2, CGS.G2, CGS.B2,255);
		ClockText.GetComponent<TextMeshProUGUI> ().color = Color.white;

		WaitText.gameObject.SetActive (true);
		//WaitText.GetComponent<TextMeshProUGUI>().color = new Color32 (255, 255, 0,255);
		WaitOnStart ();
	}
	private IEnumerator Timeout()
    {
		//Alert_Timeout.SetActive(true);
		OpenPopup();
		gameObject.GetComponent<AudioSource>().Stop();
		yield return new WaitForSeconds(2);
		SceneManager.LoadScene(4);

	}

	void WaitOnStart()
	{
		if (Seconds > 0) 
		{
			WaitText.GetComponent<MeshRenderer> ().sortingOrder = 10;
			WaitText.GetComponent<TextMeshProUGUI> ().text = Seconds.ToString ();
			Seconds--;
			Invoke ("WaitOnStart", 0.75f);
		}
		else 
		{
			WaitText.gameObject.SetActive (false);
			RMS.ManageDifficulty ();
			RMS.GenerateRandomGrid ();
			AllowTouch = true;
			Invoke("CountDown",0.01f);
		}
	}

	void PlayTickTock()
	{
		if (!TickTock) 
		{
			gameObject.GetComponent<AudioSource> ().Play ();
			TickTock = true;
		}
	}

	public void CountDown()
	{
		if (TimeLeft <= 3) 
		{
			//gameObject.GetComponent<SpriteRenderer> ().color = new Color32 (255, 0, 0,255);
			ClockText.GetComponent<TextMeshProUGUI> ().color = Color.red;
			transform.localScale = new Vector2 (1.2f,1.2f);
			PlayTickTock ();
			Invoke ("ResizeCircle",0.3f);
		} 
		else if (TimeLeft % 2 == 0) 
		{
			//gameObject.GetComponent<SpriteRenderer> ().color = new Color32 (CGS.R2, CGS.G2, CGS.B2,255);
			ClockText.GetComponent<TextMeshProUGUI> ().color = Color.white;

			if (TickTock)
			{
				gameObject.GetComponent<AudioSource> ().Stop ();
				TickTock = false;
			}
		} 
		else 
		{
			//gameObject.GetComponent<SpriteRenderer> ().color = new Color32 (CGS.R1, CGS.G1, CGS.B1,255);
			ClockText.GetComponent<TextMeshProUGUI> ().color = Color.white;

			if (TickTock)
			{
				gameObject.GetComponent<AudioSource> ().Stop ();
				TickTock = false;
			}
		}

		ClockText.GetComponent<TextMeshProUGUI> ().text = TimeLeft.ToString();
		if (TimeLeft > 0) 
		{
			ProgressBar.current = TimeLeft;
			TimeLeft--;
			Invoke ("CountDown",1);
		}
		else
		{
			ProgressBar.current = TimeLeft;
			AllowTouch = false;
			Invoke("GameOver",1.0f);
		}
	}

	/*public void AddSeconds ()
	{
		TimeLeft += 2;
		ClockText.GetComponent<TextMeshProUGUI> ().text = TimeLeft.ToString();
	}*/

	void ResizeCircle()
	{
		transform.localScale = new Vector2 (1f,1f);
	}

	public void GameOver()
	{		
		SDS.CurrentScore = SMG.TotalScore;
		StartCoroutine(Timeout());
	}
	public virtual void OpenPopup()
	{
		var popup = Instantiate(popupPrefab) as GameObject;
		popup.SetActive(true);
		popup.transform.localScale = Vector3.zero;
		popup.transform.SetParent(m_canvas.transform, false);
		popup.GetComponent<Popup>().Open();
	}
}
