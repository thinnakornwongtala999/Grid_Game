﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class ScoreMgmt : MonoBehaviour 
{
	public int Score,TotalScore;

	[SerializeField]
	GameObject PopupScore;

	[SerializeField]
	TextMeshProUGUI CurrentScoreUI;

	public void AddScore(int Tiles)
	{
		Score = (Tiles * 2);
		TotalScore += Score;
		CurrentScoreUI.text = TotalScore.ToString ();
		Instantiate (PopupScore, Vector2.zero, Quaternion.identity);
	}
}
