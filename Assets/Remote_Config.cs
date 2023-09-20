
using System.Threading.Tasks;
using Unity.Services.RemoteConfig;
using Unity.Services.Authentication;
using Unity.Services.Core;
using UnityEngine;

public class Remote_Config : MonoBehaviour
{
    public struct userAttributes { }
    public struct appAttributes { }

    public static string URL_Api_Gameset;
    public static string URL_Api_Checkcode;
    public static string URL_Api_SetReward;
    public static string ID;
    public static string CustomerName;

    async Task InitializeRemoteConfigAsync()
    {
        // initialize handlers for unity game services
        await UnityServices.InitializeAsync();

        // remote config requires authentication for managing environment information
        if (!AuthenticationService.Instance.IsSignedIn)
        {
            await AuthenticationService.Instance.SignInAnonymouslyAsync();
        }
    }

    async Task Start()
    {
        // initialize Unity's authentication and core services, however check for internet connection
        // in order to fail gracefully without throwing exception if connection does not exist
        if (Utilities.CheckForInternetConnection())
        {
            await InitializeRemoteConfigAsync();
        }

        RemoteConfigService.Instance.FetchCompleted += ApplyRemoteSettings;
        RemoteConfigService.Instance.FetchConfigs(new userAttributes(), new appAttributes());
    }

    void ApplyRemoteSettings(ConfigResponse configResponse)
    {
        Debug.Log("RemoteConfigService.Instance.appConfig fetched: " + RemoteConfigService.Instance.appConfig.config.ToString());
        URL_Api_Checkcode = RemoteConfigService.Instance.appConfig.GetString("URL_API_Checkcode");
        URL_Api_Gameset = RemoteConfigService.Instance.appConfig.GetString("URL_API_Gameset");
        URL_Api_SetReward = RemoteConfigService.Instance.appConfig.GetString("URL_API_SetReward");
        ID = RemoteConfigService.Instance.appConfig.GetString("id");
        CustomerName = RemoteConfigService.Instance.appConfig.GetString("CustomerName");
        Debug.Log(ID);
        Debug.Log(CustomerName);
    }
}