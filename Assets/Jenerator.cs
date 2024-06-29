using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateRangeRandomPosition : MonoBehaviour
{
    [SerializeField]
    [Tooltip("��������GameObject")]
    GameObject m_prefab = default;
    [SerializeField]
    [Tooltip("��������͈�A")]
    private Transform rangeA;
    [SerializeField]
    [Tooltip("��������͈�B")]
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
        // �O�t���[������̎��Ԃ����Z���Ă���
        m_timer = m_timer + Time.deltaTime;

        // ��1�b�u���Ƀ����_���ɐ��������悤�ɂ���B
        if (m_timer > 1f)
        {
            // rangeA��rangeB��x���W�͈͓̔��Ń����_���Ȑ��l���쐬
            float x = Random.Range(rangeA.position.x, rangeB.position.x);
            // rangeA��rangeB��y���W�͈͓̔��Ń����_���Ȑ��l���쐬
            float y = Random.Range(rangeA.position.y, rangeB.position.y);
            // GameObject����L�Ō��܂��������_���ȏꏊ�ɐ���
            Instantiate(m_prefab, new Vector3(x, y), m_prefab.transform.rotation);
            m_timer = 0f;
        }
        // �o�ߎ��ԃ��Z�b�g
        if (m_timer > m_interval)
        { 
            m_timer = 0f;
            Instantiate(m_prefab, this.transform.position, Quaternion.identity);
        }
    }
}