using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Loading_Time : MonoBehaviour
{
    private GameObject image_Loading;
    void Start()
    {
        image_Loading = GameObject.Find("image_Loading");
        StartCoroutine(WaitForFunction());
    }
    IEnumerator WaitForFunction()
    {
        image_Loading.SetActive(true);
        yield return new WaitForSeconds(2);
        image_Loading.SetActive(false);
        if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            yield return new WaitForSeconds(300);
            SceneManager.LoadScene(1);

        }
    }
}
