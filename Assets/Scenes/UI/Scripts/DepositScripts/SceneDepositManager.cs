using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneDepositManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public GameObject[] targets;
    public bool visiable;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //0:檢查身分證
    //1:確認流程
    //2:確認進行業務
    //3:業務核對
    //4:手語系統連線
    //5:手語系統關閉
    //6:取消操作，跳回選擇業務
    //按鈕觸發激活事件
    public void CheckIdenty()
    {
        Debug.Log("CheckIdenty");
        //檢查頁取消激活，流程頁激活
        targets[0].SetActive(false);
        targets[1].SetActive(true);
    }
    public void CheckDepositProcess()
    {
        Debug.Log("CheckDepositProcess");
        //流程頁取消激活，激活存款確認頁
        targets[1].SetActive(false);
        targets[2].SetActive(true);
    }
    public void CheckDepositYes()
    {
        Debug.Log("CheckDepositYES");
        //流程頁取消激活，激活存款確認頁
        targets[2].SetActive(false);
        targets[3].SetActive(true);
        Invoke("CheckAndWaiting", 2f);
    }
    public void CheckDepositNo()
    {
        Debug.Log("CheckDepositNO");
        targets[2].SetActive(false);
        targets[6].SetActive(true);
        //(SceneManager.GetSceneByName("0")).SetActive(true);
    }
    public void CheckAndWaiting()
    {
        Debug.Log("Waiting");
        //等待2秒後跳到連線手語頁
        Invoke("ActivateObjectConnecting", 2f);

    }
    private void ActivateObjectConnecting()
    {
        targets[3].SetActive(false);
        targets[4].SetActive(true);
        //等待2秒後跳到關閉系統頁
        Invoke("ActivateObjectDisConnecting", 2f);
    }
    private void ActivateObjectDisConnecting()
    {
        targets[4].SetActive(false);
        targets[5].SetActive(true);
        //等待2秒後跳到選擇業務頁
        Invoke("ActivateObjectChoose", 2f);
    }
    private void ActivateObjectChoose()
    {
        targets[5].SetActive(false);
        targets[6].SetActive(true);
    }
}
