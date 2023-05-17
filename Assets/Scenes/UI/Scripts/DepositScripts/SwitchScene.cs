using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Scene_Deposit()
    {

        Debug.Log("Deposit");
        //StartCoroutine(LoadDepositScene());
        SceneManager.LoadScene("Deposit");
    }
    IEnumerator LoadDepositScene()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Deposit");

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
