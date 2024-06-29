using UnityEngine;

/// <summary>
/// ��莞�Ԃ����Ɏw�肵���v���n�u���� GameObject �𐶐�����R���|�[�l���g
/// </summary>
public class random : MonoBehaviour
{
    /// <summary>��莞�Ԃ����ɐ������� GameObject �̌��ƂȂ�v���n�u</summary>
    [SerializeField] GameObject m_prefab = default;
    /// <summary>��������Ԋu�i�b�j</summary>
    [SerializeField] float m_interval = 1f;
    /// <summary>true �̏ꍇ�A�J�n���ɂ܂���������</summary>
    [SerializeField] bool m_generateOnStart = true;
    /// <summary>�^�C�}�[�v���p�ϐ�</summary>
    float m_timer;

    void Start()
    {
        if (m_generateOnStart)
        {
            m_timer = m_interval;
        }
    }

    void Update()
    {
        // Time.deltaTime �́u�O�t���[������̌o�ߎ��ԁv���擾����
        // �����ώZ���āu�o�ߎ��ԁv�����߂�̂� Unity �ł̓T�^�I�ȃv���O���~���O�̃p�^�[���ł���
        m_timer += Time.deltaTime;

        // �u�o�ߎ��ԁv���u��������Ԋu�v�𒴂�����
        if (m_timer > m_interval)
        {
            m_timer = 0;    // �^�C�}�[�����Z�b�g���Ă���
            Instantiate(m_prefab, this.transform.position, Quaternion.identity);
        }
    }
}
