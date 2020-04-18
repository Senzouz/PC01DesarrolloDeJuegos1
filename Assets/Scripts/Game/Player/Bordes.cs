using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bordes : MonoBehaviour
{

    private float Xmin, Xmax;
    void Start()
    {
        SetMinAndMax();
    }

    void SetMinAndMax()
    {
        Vector3 bounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        Xmin = -bounds.x;
        Xmax = bounds.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < Xmin)
        {
            Vector3 temp = transform.position;
            temp.x = Xmin;
            transform.position = temp;
        }
        if (transform.position.x > Xmax)
        {
            Vector3 temp = transform.position;
            temp.x = Xmax;
            transform.position = temp;
        }
    }
}
