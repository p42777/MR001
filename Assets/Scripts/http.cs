using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class http : MonoBehaviour
{
    // Start is called before the first frame update
    IEnumerator Start()
    {
        // Create a UnityWebRequest object
        UnityWebRequest www = UnityWebRequest.Get("https://127.0.0.1:8000/");

        // Send the request and wait for a response
        yield return www.SendWebRequest();

        // Check for errors
        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log(www.error);
        }
        else
        {
            // Print the response
            Debug.Log(www.downloadHandler.text);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
