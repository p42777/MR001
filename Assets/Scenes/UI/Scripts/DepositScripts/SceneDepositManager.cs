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
    //0:�ˬd������
    //1:�T�{�y�{
    //2:�T�{�i��~��
    //3:�~�Ȯֹ�
    //4:��y�t�γs�u
    //5:��y�t������
    //6:�����ާ@�A���^��ܷ~��
    //���sĲ�o�E���ƥ�
    public void CheckIdenty()
    {
        Debug.Log("CheckIdenty");
        //�ˬd�������E���A�y�{���E��
        targets[0].SetActive(false);
        targets[1].SetActive(true);
    }
    public void CheckDepositProcess()
    {
        Debug.Log("CheckDepositProcess");
        //�y�{�������E���A�E���s�ڽT�{��
        targets[1].SetActive(false);
        targets[2].SetActive(true);
    }
    public void CheckDepositYes()
    {
        Debug.Log("CheckDepositYES");
        //�y�{�������E���A�E���s�ڽT�{��
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
        //����2������s�u��y��
        Invoke("ActivateObjectConnecting", 2f);

    }
    private void ActivateObjectConnecting()
    {
        targets[3].SetActive(false);
        targets[4].SetActive(true);
        //����2�����������t�έ�
        Invoke("ActivateObjectDisConnecting", 2f);
    }
    private void ActivateObjectDisConnecting()
    {
        targets[4].SetActive(false);
        targets[5].SetActive(true);
        //����2�������ܷ~�ȭ�
        Invoke("ActivateObjectChoose", 2f);
    }
    private void ActivateObjectChoose()
    {
        targets[5].SetActive(false);
        targets[6].SetActive(true);
    }
}
