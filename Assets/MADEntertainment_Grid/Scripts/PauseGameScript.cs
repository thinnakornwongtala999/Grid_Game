using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class PauseGameScript : MonoBehaviour 
{
	bool IsPaused;
	public GameObject PausePanel;

	public Text PauseText;
	public TextMeshProUGUI ScoreText;
	public Text PauseButtonText;
	public Image PauseButtonImage;

	public Image PlayButtonImage;
	public Text PlayButtonText;
	public Image MenuButtonImage;
	public Text MenuButtonText;

	[SerializeField]
	GameObject Clock;
	ClockScript CSK;

	GameObject DataManager;

	void Start () 
	{
		CSK = Clock.GetComponent<ClockScript> ();
		DataManager = GameObject.FindGameObjectWithTag ("DM");
		ScoreText.color = new Color32 (255, 255, 0,255);
	}

	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			Pause();
		}
	}

	public void Pause()
	{
		if (IsPaused) 
		{
			PausePanel.SetActive (false);
			Time.timeScale = 1;
			CSK.AllowTouch = true;
		} 
		else 
		{
			PausePanel.SetActive (true);
			Time.timeScale = 0;
			CSK.AllowTouch = false;
		}
		IsPaused = !IsPaused;
	}

	public void MainMenu()
	{
		Time.timeScale = 1;
		SceneManager.LoadScene (1);
	}
}
