using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotateOver1();
    }

    public void RotateOver1()
    {
        transform.position += new Vector3(Mathf.Sin(Time.time) * 0.0025f, 0, Mathf.Cos(Time.time) * 0.0025f);
    }
    public void RotateOver2()
    {
        transform.position += new Vector3(Mathf.Sin(Time.time)*0.02f, Mathf.Cos(Time.time) * 0.02f, 0);
    }
}
