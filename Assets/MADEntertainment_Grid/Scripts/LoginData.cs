using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LoginData : MonoBehaviour
{
    [SerializeField]
    GameObject inputField;
    
    [SerializeField]
    GameObject ButtonPlay;

    private string text;
    void Start()
    {
        ButtonPlay.SetActive(false);
        inputField.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        CheckLogin();
    }

    private void CheckLogin()
    {
        text = inputField.GetComponent<TMP_InputField>().text;
        if (text == "1234")
        {
            ButtonPlay.SetActive(true);
            inputField.SetActive(false);
        }
        else
        {
            inputField.SetActive(true);
            ButtonPlay.SetActive(false);
        }
    }
}
