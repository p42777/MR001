using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectVisibilityManager : MonoBehaviour
{

    // 這裡使用SerializeField來管理一個Scene的遊戲物件
    [SerializeField] public GameObject[] targets;
    public bool visiable;
    // Use this for initialization
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        foreach (GameObject obj in targets)
        {
            obj.SetActive(false);
        }
        if(currentScene.name == "0")
        {
            Scene0Active(targets);
        }
        if (currentScene.name == "Deposit")
        {
            SceneDepositActive(targets);
        }
        if (currentScene.name == "Withdraw")
        {
            SceneWithdrawActive(targets);
        }
        if (currentScene.name == "Open")
        {
            SceneOpenActive(targets);
        }
        if (currentScene.name == "Transfer")
        {
            SceneTransferActive(targets);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Scene0Active(GameObject[]  targets)
    {
        //顯示icon
        targets[0].SetActive(true);
        //等待兩秒開始出現歡迎文字
        Invoke("ActivateObjectTyping", 2f);

        
    }
    private void ActivateObjectTyping()
    {
        targets[0].SetActive(false);
        targets[1].SetActive(true);
        //等待4秒跳到選擇業務頁
        Invoke("ActivateObjectChoose2", 4f);

    }
    private void ActivateObjectChoose2()
    {
        targets[1].SetActive(false);
        targets[2].SetActive(true);
    }
    public void SceneDepositActive(GameObject[] targets)
    {
        //激活第一個物件
        targets[0].SetActive(true);
        //0:檢查身分證
        //1:確認流程
        //2:確認進行業務
        //3:業務核對
        //4:手語系統連線
        //5:手語系統關閉
        //6:取消操作，跳回選擇業務

    }
    public void SceneWithdrawActive(GameObject[] targets)
    {
        //激活第一個物件
        targets[0].SetActive(true);//這邊我不太確定
        //0:檢查身分證
        //1:確認流程
        //2:確認進行業務
        //3:業務核對
        //4:手語系統連線
        //5:手語系統關閉
        //6:取消操作，跳回選擇業務

    }
    public void SceneOpenActive(GameObject[] targets)
    {
        //激活第一個物件
        targets[0].SetActive(true);//這邊我不太確定
        //0:檢查身分證
        //1:確認流程
        //2:確認進行業務
        //3:業務核對
        //4:手語系統連線
        //5:手語系統關閉
        //6:取消操作，跳回選擇業務

    }
    public void SceneTransferActive(GameObject[] targets)
    {
        //激活第一個物件
        targets[0].SetActive(true);//這邊我不太確定
        //0:檢查身分證
        //1:確認流程
        //2:確認進行業務
        //3:業務核對
        //4:手語系統連線
        //5:手語系統關閉
        //6:取消操作，跳回選擇業務

    }

}
