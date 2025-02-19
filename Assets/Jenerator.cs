using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateRangeRandomPosition : MonoBehaviour
{
    [SerializeField]
    [Tooltip("生成するGameObject")]
    GameObject m_prefab = default;
    [SerializeField]
    [Tooltip("生成する範囲A")]
    private Transform rangeA;
    [SerializeField]
    [Tooltip("生成する範囲B")]
    private Transform rangeB;
    [SerializeField] float m_interval = 1f;
    [SerializeField] bool m_generateOnStart = true;
    float m_timer;
    void Start()
    {
        if (m_generateOnStart)
        {
            m_timer = m_interval;
        }
    }
    // Update is called once per frame
    void Update()
    {
        // 前フレームからの時間を加算していく
        m_timer = m_timer + Time.deltaTime;

        // 約1秒置きにランダムに生成されるようにする。
        if (m_timer > 1f)
        {
            // rangeAとrangeBのx座標の範囲内でランダムな数値を作成
            float x = Random.Range(rangeA.position.x, rangeB.position.x);
            // rangeAとrangeBのy座標の範囲内でランダムな数値を作成
            float y = Random.Range(rangeA.position.y, rangeB.position.y);
            // GameObjectを上記で決まったランダムな場所に生成
            Instantiate(m_prefab, new Vector3(x, y), m_prefab.transform.rotation);
            m_timer = 0f;
        }
        // 経過時間リセット
        if (m_timer > m_interval)
        { 
            m_timer = 0f;
            Instantiate(m_prefab, this.transform.position, Quaternion.identity);
        }
    }
}