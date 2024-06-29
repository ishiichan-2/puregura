using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    [SerializeField] float _timer = 50;
    [SerializeField] Text _timerText;
    public bool IsTimer = true;
    // Start is called before the first frame update
    void Start()
    {
        IsTimer = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsTimer)
        {
            _timer -= Time.deltaTime;
            _timerText.text = _timer.ToString("F1");
            if (_timer <= 0)
            {
                _timer = 0;
                SceneManager.LoadScene("Clear");
            }
        }

    }
}
