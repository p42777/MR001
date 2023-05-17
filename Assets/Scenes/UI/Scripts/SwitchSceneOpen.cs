using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchSceneOpen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Scene_Open()
    {

        Debug.Log("Open");
        //StartCoroutine(LoadDepositScene());
        SceneManager.LoadScene("Open");
    }
    IEnumerator LoadOpenScene()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Open");

        // ������٨S�������[���ɡAasyncLoad.isDone���Ȭ�false
        while (!asyncLoad.isDone)
        {
            // ��s�i�ױ�
            float progress = Mathf.Clamp01(asyncLoad.progress / 0.9f);
            Debug.Log("Loading progress: " + progress);

            // ���y�@�V
            yield return null;
        }
    }


}
