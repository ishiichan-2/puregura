using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 a = Input.mousePosition;
        Vector2 b = Camera.main.ScreenToWorldPoint(a);
        transform.position = b;
    }
}
