using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [Header("���ʳt��"),Tooltip("�Ǫ��t��"),Range(0,10)]
    public float speed=3.5f;

    [Header("�����O"), Tooltip("�Ǫ�����"), Range(0, 500)]
    public int atk = 100;

    [Header("�����O"), Tooltip("�Ǫ���q"), Range(0, 5000)]
    public int hp = 350;

    [Header("�l�ܽd��"), Range(0, 50)]
    public int trace_range = 30;

    [Header("�l�ܦ첾")]
    public Vector3  trace_offset;

    [Header("�����D��")]
    public GameObject fall_tool;

    [Header("�����D����v"), Range(0, 1)]
    public float tool_percent;

    [Header("�����D�㭵��")]
    public AudioClip tool_BGM;

    [Header("���˭���"), Range(0, 1)]
    public AudioClip BGM_inj;

    [Header("�������Į�"), Range(0, 1)]
    public AudioClip BGM_atk;

    [Header("���Ĩӷ�")]
    private AudioSource BGM_Sor;
    [Header("2D����")]
    private Rigidbody2D rigi_hard;
    [Header("�ʵe���")]
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
