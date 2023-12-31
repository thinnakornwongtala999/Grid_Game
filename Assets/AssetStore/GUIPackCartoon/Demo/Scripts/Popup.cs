// Copyright (C) 2015-2023 ricimi - All rights reserved.
// This code can only be used under the standard Unity Asset Store End User License Agreement.
// A Copy of the Asset Store EULA is available at http://unity3d.com/company/legal/as_terms.

using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Ricimi
{
    // This class is responsible for popup management. Popups follow the traditional behavior of
    // automatically blocking the input on elements behind it and adding a background texture.
    public class Popup : MonoBehaviour
    {
        public Color backgroundColor = new Color(10.0f / 255.0f, 10.0f / 255.0f, 10.0f / 255.0f, 0.6f);

        private GameObject m_background;

        //public GameObject popup_Alert;
        [SerializeField] GameObject image_AlertSuccess;
        [SerializeField] GameObject image_AlertError;
        [SerializeField] GameObject image_Alert_timeout;

        private void Start()
        {
            if (SceneManager.GetActiveScene().buildIndex == 1)
            {
                StartCoroutine(CloseVideo());
            }
            if (SceneManager.GetActiveScene().buildIndex == 2)
            {
                if(GetData.checkStatus == true)
                {
                    image_AlertError.SetActive(false);
                    image_Alert_timeout.SetActive(false);
                    image_AlertSuccess.SetActive(true);
                }
                else if (GetData.checkStatus == false)
                {
                    image_AlertSuccess.SetActive(false);
                    image_Alert_timeout.SetActive(false);
                    image_AlertError.SetActive(true);
                }
                StartCoroutine(ClosePopup());
            }
            else if (SceneManager.GetActiveScene().buildIndex == 3)
            {
                image_AlertSuccess.SetActive(false);
                image_AlertError.SetActive(false);
                image_Alert_timeout.SetActive(true);
            }
        }
        private IEnumerator ClosePopup()
        {
            yield return new WaitForSeconds(2);
            Close();
        }
        private IEnumerator CloseVideo()
        {
            yield return new WaitForSeconds(36);
            Close();
        }
        public void Open()
        {
            AddBackground();
        }

        public void Close()
        {
            var animator = GetComponent<Animator>();
            if (animator.GetCurrentAnimatorStateInfo(0).IsName("Open"))
                animator.Play("Close");

            RemoveBackground();
            StartCoroutine(RunPopupDestroy());
        }

        // We destroy the popup automatically 0.5 seconds after closing it.
        // The destruction is performed asynchronously via a coroutine. If you
        // want to destroy the popup at the exact time its closing animation is
        // finished, you can use an animation event instead.
        private IEnumerator RunPopupDestroy()
        {
            yield return new WaitForSeconds(0.5f);
            Destroy(m_background);
            Destroy(gameObject);
        }

        private void AddBackground()
        {
            var bgTex = new Texture2D(1, 1);
            bgTex.SetPixel(0, 0, backgroundColor);
            bgTex.Apply();

            m_background = new GameObject("PopupBackground");
            var image = m_background.AddComponent<Image>();
            var rect = new Rect(0, 0, bgTex.width, bgTex.height);
            var sprite = Sprite.Create(bgTex, rect, new Vector2(0.5f, 0.5f), 1);
            image.material.mainTexture = bgTex;
            image.sprite = sprite;
            var newColor = image.color;
            image.color = newColor;
            image.canvasRenderer.SetAlpha(0.0f);
            image.CrossFadeAlpha(1.0f, 0.4f, false);

            var canvas = GameObject.Find("Canvas");
            m_background.transform.localScale = new Vector3(1, 1, 1);
            m_background.GetComponent<RectTransform>().sizeDelta = canvas.GetComponent<RectTransform>().sizeDelta;
            m_background.transform.SetParent(canvas.transform, false);
            m_background.transform.SetSiblingIndex(transform.GetSiblingIndex());
        }

        private void RemoveBackground()
        {
            var image = m_background.GetComponent<Image>();
            if (image != null)
                image.CrossFadeAlpha(0.0f, 0.2f, false);
        }
    }
}
