using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    /// <summary>
    /// “ä‚Ì” ‚æ‚­‚í‚©‚ç‚ñ
    /// </summary>
    [SerializeField] public GameObject hitPoint;
    /// <summary>
    /// 
    /// </summary>
    [SerializeField] float _interval = 0;
    bool _isAtack;
    [SerializeField] float _intervalMax = 1;
    private float _timer;
    AudioSource _audioSource;
    // Start is called before the first frame update
    void Start()
    {
        // hitPoint.SetActive(false);
        _audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _isAtack = true;
            //hitPoint.SetActive(true);
            _timer = 0;
            Debug.Log("Click");
        }
        if(_interval<_timer)
        {
            _isAtack = false;
        }
        _timer += Time.deltaTime;
        //if (Input.GetMouseButtonUp(0))
        //{
        //    _isAtack = false;
        //}
        //    if (Input.GetKeyDown(KeyCode.F))
        //    {
        //    Collider2D collider = GetComponent<Collider2D>();
        //    collider.enabled = true;
        //    }
        //if(Input.GetKeyUp(KeyCode.F))
        //{
        //    Collider2D collider = GetComponent<Collider2D>();
        //    collider.enabled = false;
        //}

    }
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.gameObject.tag == "Enemy" && _isAtack == true)
    //    {
    //        Destroy(collision.gameObject);
    //    }
    //}

    private void OnTriggerStay2D(Collider2D collision)
    {
        //Debug.Log("HIT");
        if (_isAtack == true && collision.gameObject.tag == "Enemy")
        {
            _audioSource.Play();
            Destroy(collision.gameObject);
            Debug.Log(collision.name);
        }


    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (Input.GetMouseButton(0) && collision.gameObject.tag == "Enemy")
    //    {
    //        Destroy(collision.gameObject);
    //    }
    //}
}