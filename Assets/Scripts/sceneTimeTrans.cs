using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class sceneTimeTrans : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //���o��escene�W��
        string sceneName = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;
        Thread.Sleep(5000);
        if (sceneName == "0")
        {
            // �Ȱ��{������5��
            Thread.Sleep(5000);
            Debug.Log("0");
            SceneManager.LoadScene("1");
        }
        if (sceneName == "1")
        {
            // �Ȱ��{������5��
            Thread.Sleep(5000);
            Debug.Log("1");
            SceneManager.LoadScene("2");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
