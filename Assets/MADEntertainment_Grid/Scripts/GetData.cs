using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using TMPro;
using Newtonsoft.Json;
using System.Text;
using UnityEngine.SceneManagement;
using System;

namespace Ricimi
{
    public class GetData : MonoBehaviour
    {
        public class Status
        {
            public bool status { get; set; }
            public string gamecode { get; set; }
        }

        [SerializeField]
        GameObject ButtonPlay;

        [SerializeField]
        GameObject KeyPad;

        [SerializeField] TextMeshProUGUI number1;
        [SerializeField] TextMeshProUGUI number2;
        [SerializeField] TextMeshProUGUI number3;
        [SerializeField] TextMeshProUGUI number4;
        [SerializeField] GameObject LoadDataFailde;

        public GameObject background_qr;

        public static bool checkStatus;
        public static string checkCode;
        public GameObject popupPrefab;

        protected Canvas m_canvas;

        SaveDataScript SDS;
        GameObject DataManager;

        void Start()
        {
            ButtonPlay.SetActive(false);
            KeyPad.SetActive(true);
            buttonX();
            m_canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
            DataManager = GameObject.FindGameObjectWithTag("DM");
            SDS = DataManager.GetComponent<SaveDataScript>();
            background_qr.gameObject.SetActive(true);
        }

        //void GetDataWeb() => StartCoroutine(MakeRequests());
        private IEnumerator MakeRequests()
        {
            // POST
            var dataToPost = new PostData() { gamecode = number1.text + number2.text + number3.text + number4.text, ref_code = Remote_Config.ID };
            var postRequest = CreateRequest(Remote_Config.URL_Api_Checkcode, RequestType.POST, dataToPost);
            yield return postRequest.SendWebRequest();
            if (postRequest.result == UnityWebRequest.Result.ProtocolError || postRequest.result == UnityWebRequest.Result.ConnectionError)
            {
                LoadDataFailde.SetActive(true);
                //Debug.Log(postRequest.error);
            }
            else
            {
                Status status = JsonConvert.DeserializeObject<Status>(postRequest.downloadHandler.text);
                checkStatus = status.status;
                checkCode = status.gamecode;
                if (checkStatus == true)
                {
                    //Debug.Log("Login Success !!");
                    OpenPopup();
                    yield return new WaitForSeconds(2);
                    background_qr.gameObject.SetActive(false);
                    KeyPad.SetActive(false);
                    ButtonPlay.SetActive(true);
                }
                else
                {
                    //Debug.Log("Login Failed !!");
                    buttonX();
                    OpenPopup();
                    yield return new WaitForSeconds(2);
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

        public void button1()
        {
            if (number1.text == null)
            {
                number1.text = "1";
            }
            else if (number2.text == null)
            {
                number2.text = "1";
            }
            else if (number3.text == null)
            {
                number3.text = "1";
            }
            else if (number4.text == null)
            {
                number4.text = "1";
            }
            CheckData();
        }
        public void button2()
        {
            if (number1.text == null)
            {
                number1.text = "2";
            }
            else if (number2.text == null)
            {
                number2.text = "2";
            }
            else if (number3.text == null)
            {
                number3.text = "2";
            }
            else if (number4.text == null)
            {
                number4.text = "2";
            }
            CheckData();
        }
        public void button3()
        {
            if (number1.text == null)
            {
                number1.text = "3";
            }
            else if (number2.text == null)
            {
                number2.text = "3";
            }
            else if (number3.text == null)
            {
                number3.text = "3";
            }
            else if (number4.text == null)
            {
                number4.text = "3";
            }
            CheckData();
        }
        public void button4()
        {
            if (number1.text == null)
            {
                number1.text = "4";
            }
            else if (number2.text == null)
            {
                number2.text = "4";
            }
            else if (number3.text == null)
            {
                number3.text = "4";
            }
            else if (number4.text == null)
            {
                number4.text = "4";
            }
            CheckData();
        }
        public void button5()
        {
            if (number1.text == null)
            {
                number1.text = "5";
            }
            else if (number2.text == null)
            {
                number2.text = "5";
            }
            else if (number3.text == null)
            {
                number3.text = "5";
            }
            else if (number4.text == null)
            {
                number4.text = "5";
            }
            CheckData();
        }
        public void button6()
        {
            if (number1.text == null)
            {
                number1.text = "6";
            }
            else if (number2.text == null)
            {
                number2.text = "6";
            }
            else if (number3.text == null)
            {
                number3.text = "6";
            }
            else if (number4.text == null)
            {
                number4.text = "6";
            }
            CheckData();
        }
        public void button7()
        {
            if (number1.text == null)
            {
                number1.text = "7";
            }
            else if (number2.text == null)
            {
                number2.text = "7";
            }
            else if (number3.text == null)
            {
                number3.text = "7";
            }
            else if (number4.text == null)
            {
                number4.text = "7";
            }
            CheckData();
        }
        public void button8()
        {
            if (number1.text == null)
            {
                number1.text = "8";
            }
            else if (number2.text == null)
            {
                number2.text = "8";
            }
            else if (number3.text == null)
            {
                number3.text = "8";
            }
            else if (number4.text == null)
            {
                number4.text = "8";
            }
            CheckData();
        }
        public void button9()
        {
            if (number1.text == null)
            {
                number1.text = "9";
            }
            else if (number2.text == null)
            {
                number2.text = "9";
            }
            else if (number3.text == null)
            {
                number3.text = "9";
            }
            else if (number4.text == null)
            {
                number4.text = "9";
            }
            CheckData();
        }
        public void button0()
        {
            if (number1.text == null)
            {
                number1.text = "0";
            }
            else if (number2.text == null)
            {
                number2.text = "0";
            }
            else if (number3.text == null)
            {
                number3.text = "0";
            }
            else if (number4.text == null)
            {
                number4.text = "0";
            }
            CheckData();
        }
        public void buttonX()
        {
            number1.text = null;
            number2.text = null;
            number3.text = null;
            number4.text = null;
        }
        public void buttonDelete()
        {
            if (number4.text != null)
            {
                number4.text = null;
            }
            else if (number3.text != null)
            {
                number3.text = null;
            }
            else if (number2.text != null)
            {
                number2.text = null;
            }
            else if (number1.text != null)
            {
                number1.text = null;
            }
        }

        public void CheckData()
        {
            if (number1.text != null & number2.text != null & number3.text != null & number4.text != null)
            {
                StartCoroutine(MakeRequests());
            }
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
    public enum RequestType
    {
        GET = 0,
        POST = 1,
        PUT = 2
    }


    public class Todo
    {
        // Ensure no getters / setters
        // Typecase has to match exactly
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

    /*public class PostResult
    {
        public string qrcode { get; set; }
        public string imgReward { get; set; }
        public string logo_cobiz19 { get; set; }
        public string Background_main { get; set; }
        public string Background_qr { get; set; }
        public string Background_null { get; set; }
        public string Background_AlertError { get; set; }
        public string Background_AlertSuccess { get; set; }
    }*/
}
