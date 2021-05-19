using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Facebook.Unity;
using UnityEngine.UI;

public class FBController : MonoBehaviour
{
    public GameObject usernameF;
    private void Awake()
    {
        FB.Init(SetInit, OnHideUnity);
    }
    void SetInit()
    {
        if (FB.IsLoggedIn) { 
            Debug.Log("Successfully");
        }
        else
        {
            Debug.Log("QQ");
        }
        
    }
    void OnHideUnity(bool isGameShown)
    {
        if (isGameShown)
        {
            Time.timeScale = 1;
        }
        else
        {
            Time.timeScale = 0;
        }
    }
    public void FBlogin()
    {
        List<string> permissions = new List<string>();
        permissions.Add("public_profile");
        FB.LogInWithReadPermissions(permissions, AuthCallResult);
    }
    void AuthCallResult(ILoginResult result)
    {
        if(result.Error != null)
        {
            Debug.Log(result.Error);
        }
        else
        {
            if(FB.IsLoggedIn)
            {
                Debug.Log("FB logged in");
                FB.API("/me?fields=first_name", HttpMethod.GET, callbackData);
            }else
            {
                Debug.Log("Login Failed");
            }
        }
    }
    void callbackData(IResult res)
    {
        Text username = usernameF.GetComponent<Text>();
        if(res.Error != null)
        {
            Debug.Log("Error getting data");
        }
        else
        {
            username.text = "Welcome back," + res.ResultDictionary["first_name"];
        }
    }



}
