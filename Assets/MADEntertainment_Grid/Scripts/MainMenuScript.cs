using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour 
{
	SaveDataScript SDS;
	ThemeChangeScript CGS;

	GameObject DataManager;

	[SerializeField]
	GameObject Buttons;

	void Start () 
	{
		DataManager = GameObject.FindGameObjectWithTag ("DM");
		SDS = DataManager.GetComponent<SaveDataScript> ();
		CGS = DataManager.GetComponent<ThemeChangeScript> ();

		CGS.ChangeTheme ();
	}

	public void Mute()
	{
		if(AudioListener.volume == 1)
		{
			AudioListener.volume= 0;
		}
		else
		{
			AudioListener.volume= 1;
		}
	}

	public void Play()
	{
		Buttons.SetActive (false);
	}

	public void Back()
	{
		Buttons.SetActive (true);
	}

	public void Quit()
	{
		Application.Quit ();
	}

	public void SelectGameMode(int GameMode)
	{
		SDS.GameMode = GameMode;
		SceneManager.LoadScene (2);
	}
}
