using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //----0906-----WK-----Ce---
    /// <summary>
    /// ��ܤ��e
    /// </summary>
    /// <param name="Conversation">��ܤ��e�ܼ�</param>
    /// <returns></returns>
    private void Conversation(string conversa) {  }


    /// <summary>
    /// �}�Ұө�
    /// </summary>
    /// <param name="Store_Open">�}�Ұө��Ѽ�</param>
    /// <returns></returns>
    public bool Stroe_on(bool Store_Open ) { return true; }

    // public int SPrice(int price=100) {  }
    /// <summary>
    /// �ʶR�D��
    /// </summary>
    /// <param name="tool_price">�D������Ѽ�</param>
    /// <returns></returns>
    public int S_Price(int s_price = 100) { return 0; }

    /// <summary>
    /// ���o����
    /// </summary>
    /// <param name="Mis_No">���Ƚs���Ѽ�</param>
    /// <returns></returns>
    public void Mission_No (int Mis_No){}
    /// <summary>
    /// ���ȧ�s
    /// </summary>
    /// <param name="Mis_Upd">���ȰѼ�</param>
    /// <returns></returns>
    private int Mission_Upd(int Mis_Upd){ return 0; }

    /// <summary>
    /// ��������
    /// </summary>
    /// <param name="Mis_Done">���Ƚs��</param>
    /// <returns></returns>
    private bool Mission_Done(int Mis_Done) { return false; }



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
