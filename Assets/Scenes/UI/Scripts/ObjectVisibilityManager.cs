using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectVisibilityManager : MonoBehaviour
{

    // �o�̨ϥ�SerializeField�Ӻ޲z�@��Scene���C������
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
        //���icon
        targets[0].SetActive(true);
        //���ݨ��}�l�X�{�w���r
        Invoke("ActivateObjectTyping", 2f);

        
    }
    private void ActivateObjectTyping()
    {
        targets[0].SetActive(false);
        targets[1].SetActive(true);
        //����4������ܷ~�ȭ�
        Invoke("ActivateObjectChoose2", 4f);

    }
    private void ActivateObjectChoose2()
    {
        targets[1].SetActive(false);
        targets[2].SetActive(true);
    }
    public void SceneDepositActive(GameObject[] targets)
    {
        //�E���Ĥ@�Ӫ���
        targets[0].SetActive(true);
        //0:�ˬd������
        //1:�T�{�y�{
        //2:�T�{�i��~��
        //3:�~�Ȯֹ�
        //4:��y�t�γs�u
        //5:��y�t������
        //6:�����ާ@�A���^��ܷ~��

    }
    public void SceneWithdrawActive(GameObject[] targets)
    {
        //�E���Ĥ@�Ӫ���
        targets[0].SetActive(true);//�o��ڤ��ӽT�w
        //0:�ˬd������
        //1:�T�{�y�{
        //2:�T�{�i��~��
        //3:�~�Ȯֹ�
        //4:��y�t�γs�u
        //5:��y�t������
        //6:�����ާ@�A���^��ܷ~��

    }
    public void SceneOpenActive(GameObject[] targets)
    {
        //�E���Ĥ@�Ӫ���
        targets[0].SetActive(true);//�o��ڤ��ӽT�w
        //0:�ˬd������
        //1:�T�{�y�{
        //2:�T�{�i��~��
        //3:�~�Ȯֹ�
        //4:��y�t�γs�u
        //5:��y�t������
        //6:�����ާ@�A���^��ܷ~��

    }
    public void SceneTransferActive(GameObject[] targets)
    {
        //�E���Ĥ@�Ӫ���
        targets[0].SetActive(true);//�o��ڤ��ӽT�w
        //0:�ˬd������
        //1:�T�{�y�{
        //2:�T�{�i��~��
        //3:�~�Ȯֹ�
        //4:��y�t�γs�u
        //5:��y�t������
        //6:�����ާ@�A���^��ܷ~��

    }

}
