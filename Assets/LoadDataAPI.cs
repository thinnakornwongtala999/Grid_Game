using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;

public class LoadDataAPI : MonoBehaviour
{

    public static string Background_main_uri;
    public static string Background_qr_uri;
    public static string Background_null_uri;
    public static string Background_AlertError_uri;
    public static string Background_AlertSuccess_uri;
    public static string Background_Button_tap_uri;
    public static string Background_thank_uri;
    public static string Background_Button_home_uri;
    public static string Background_Alert_timeout_uri;
    public static string Background_Button_num_uri;
    public static string Background_Button_press_uri;
    public static string Background_Button_click_uri;
    public static string Background_Button_uri;

    //[SerializeField] TMP_InputField _InputField;
    private void Start()
    {
        StartCoroutine(MakeRequests());
    }

    private IEnumerator MakeRequests()
    {
        yield return new WaitForSeconds(2);
        // POST
        var dataToPost = new PostDatas() { id = Remote_Config.ID, CustomerName = Remote_Config.CustomerName };
        var postRequest = CreateRequest(Remote_Config.URL_Api_Gameset, RequestTypes.POST, dataToPost);
        yield return postRequest.SendWebRequest();
        PostResults img = JsonConvert.DeserializeObject<PostResults>(postRequest.downloadHandler.text);
        //_InputField.text = postRequest.downloadHandler.text;
        //qrcode_uri = img.qrcode;
        //logo_cobiz19_uri = img.logo_cobiz19;
        Background_main_uri = img.Background_main;
        Background_qr_uri = img.Background_qr;
        Background_null_uri = img.Background_null;
        Background_AlertError_uri = img.Background_Alert_error;
        Background_AlertSuccess_uri = img.Background_Alert_succes;
        Background_Button_tap_uri = img.Background_Button_tap;
        Background_thank_uri = img.Background_thank;
        Background_Button_home_uri = img.Background_Button_home;
        Background_Alert_timeout_uri = img.Background_Alert_timeout;
        Background_Button_num_uri = img.Background_Button_num;
        Background_Button_press_uri = img.Background_Button_press;
        Background_Button_click_uri = img.Background_Button_click;
        Background_Button_uri = img.Background_Button;
    }

    private UnityWebRequest CreateRequest(string path, RequestTypes type = RequestTypes.GET, object data = null)
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
}

public enum RequestTypes
{
    GET = 0,
    POST = 1,
    PUT = 2
}


public class Todos
{
    public int userId;
    public int id;
    public string title;
    public bool completed;
}

[Serializable]
public class PostDatas
{
    public string id;
    public string CustomerName;
    public string gamecode;
    public string ref_code;
    public string create_date;
    public string score;
}

public class PostResults
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
    public string Background_Alert_timeout { get; set; }
    public string Background_Button_num { get; set; }
    public string Background_Button_click { get; set; }
    public string Background_Button_press { get; set; }
    public string Background_Button { get; set; }
}
