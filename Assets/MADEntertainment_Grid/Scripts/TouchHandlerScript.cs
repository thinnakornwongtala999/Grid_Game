using UnityEngine;
using System.Collections;
using System.IO;

public class TouchHandlerScript : MonoBehaviour 
{
	[SerializeField]
	Sprite PurpleSprite; 
	[SerializeField]
	Sprite GreySprite;

	[SerializeField]
	GameObject TouchEffect;

	[SerializeField]
	GameObject Clock;

	[SerializeField]
	int Row;
	[SerializeField]
	int Column;

	public bool IsClicked;
	GameObject GameManager;
	GameObject DataManager;
	CheckForMatchScript CMS;
	ThemeChangeScript CGS;
	ClockScript CSK;

	void Start () 
	{
		byte[] textureBytes = File.ReadAllBytes(Application.persistentDataPath + "Background_Button_click");
		Texture2D loadedTexture = new Texture2D(0, 0);
		loadedTexture.LoadImage(textureBytes);
		Sprite sprite = Sprite.Create(loadedTexture, new Rect(0, 0, loadedTexture.width, loadedTexture.height), new Vector2(0.5f, 0.5f));
		PurpleSprite = sprite;

		byte[] textureBytes1 = File.ReadAllBytes(Application.persistentDataPath + "Background_Button_press");
		Texture2D loadedTexture1 = new Texture2D(0, 0);
		loadedTexture1.LoadImage(textureBytes1);
		Sprite sprite1 = Sprite.Create(loadedTexture1, new Rect(0, 0, loadedTexture1.width, loadedTexture1.height), new Vector2(0.5f, 0.5f));
		GreySprite = sprite1;

		GameManager = GameObject.FindGameObjectWithTag ("GM");
		CMS = GameManager.GetComponent<CheckForMatchScript> ();
		DataManager = GameObject.FindGameObjectWithTag ("DM");
		CGS = DataManager.GetComponent<ThemeChangeScript> ();
		CSK = Clock.GetComponent<ClockScript> ();
	}

	void OnMouseDown()
	{
		if (CSK.AllowTouch) 
		{
			if (!IsClicked) 
			{
				gameObject.GetComponent<SpriteRenderer> ().sprite = PurpleSprite;
				Instantiate (TouchEffect, transform.position, Quaternion.Euler (0.0f, 0.0f, 45.0f));
				CMS.PlayAudio ();
				CMS.SetGridValue (Row, Column, true);
			} 
			else 
			{
				gameObject.GetComponent<SpriteRenderer> ().sprite = GreySprite;
				Instantiate (TouchEffect, transform.position, Quaternion.Euler (0.0f, 0.0f, 45.0f));

				CMS.SetGridValue (Row, Column, false);
			}
			IsClicked = !IsClicked;
		}
	}
}
