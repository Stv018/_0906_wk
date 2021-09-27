using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [Header("移動速度"),Tooltip("怪物速度"),Range(0,10)]
    public float speed=3.5f;

    [Header("攻擊力"), Tooltip("怪物攻擊"), Range(0, 500)]
    public int atk = 100;

    [Header("攻擊力"), Tooltip("怪物血量"), Range(0, 5000)]
    public int hp = 350;

    [Header("追蹤範圍"), Range(0, 50)]
    public int trace_range = 30;

    [Header("追蹤位移")]
    public Vector3  trace_offset;

    [Header("掉落道具")]
    public GameObject fall_tool;

    [Header("掉落道具機率"), Range(0, 1)]
    public float tool_percent;

    [Header("掉落道具音效")]
    public AudioClip tool_BGM;

    [Header("受傷音效"), Range(0, 1)]
    public AudioClip BGM_inj;

    [Header("攻擊音效效"), Range(0, 1)]
    public AudioClip BGM_atk;

    [Header("音效來源")]
    private AudioSource BGM_Sor;
    [Header("2D鋼體")]
    private Rigidbody2D rigi_hard;
    [Header("動畫控制器")]
    private Animator anim_trl;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
