using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchSceneTransfer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Scene_Transfer()
    {

        Debug.Log("Transfer");
        //StartCoroutine(LoadDepositScene());
        SceneManager.LoadScene("Transfer");
    }
    IEnumerator LoadTransferwScene()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Transfer");

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
