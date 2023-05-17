using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchSceneWithdraw : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Scene_Withdraw()
    {

        Debug.Log("Withdraw");
        //StartCoroutine(LoadDepositScene());
        SceneManager.LoadScene("Withdraw");
    }
    IEnumerator LoadWithdrawScene()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Withdraw");

        // 當場景還沒有完全加載時，asyncLoad.isDone的值為false
        while (!asyncLoad.isDone)
        {
            // 更新進度條
            float progress = Mathf.Clamp01(asyncLoad.progress / 0.9f);
            Debug.Log("Loading progress: " + progress);

            // 停頓一幀
            yield return null;
        }
    }


}
