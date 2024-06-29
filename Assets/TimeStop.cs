using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeStop : MonoBehaviour
{
    timer _timer;
    // Start is called before the first frame update
    void Start()
    {
        _timer = GameObject.Find("GameManejer").GetComponent<timer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnDestroy()
    {
        _timer.IsTimer = false;
    }
}
