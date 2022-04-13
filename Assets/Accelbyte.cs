using System;
using System.Collections;
using System.Collections.Generic;
using AccelByte.Api;
using AccelByte.Core;
using UnityEngine;

public class Accelbyte : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        User user = AccelBytePlugin.GetUser();
        user?.LoginWithDeviceId(OnLoginResult);
    }

    private void OnLoginResult(Result result)
    {
        if (result.IsError)
        {
            Debug.LogError(result.Error.Message);
        }
        else
        {
            Debug.Log("success");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
