using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //----0906-----WK-----Ce---
    /// <summary>
    /// 對話內容
    /// </summary>
    /// <param name="Conversation">對話內容變數</param>
    /// <returns></returns>
    private void Conversation(string conversa) {  }


    /// <summary>
    /// 開啟商店
    /// </summary>
    /// <param name="Store_Open">開啟商店參數</param>
    /// <returns></returns>
    public bool Stroe_on(bool Store_Open ) { return true; }

    // public int SPrice(int price=100) {  }
    /// <summary>
    /// 購買道具
    /// </summary>
    /// <param name="tool_price">道具價錢參數</param>
    /// <returns></returns>
    public int S_Price(int s_price = 100) { return 0; }

    /// <summary>
    /// 取得任務
    /// </summary>
    /// <param name="Mis_No">任務編號參數</param>
    /// <returns></returns>
    public void Mission_No (int Mis_No){}
    /// <summary>
    /// 任務更新
    /// </summary>
    /// <param name="Mis_Upd">任務參數</param>
    /// <returns></returns>
    private int Mission_Upd(int Mis_Upd){ return 0; }

    /// <summary>
    /// 完成任務
    /// </summary>
    /// <param name="Mis_Done">任務編號</param>
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
