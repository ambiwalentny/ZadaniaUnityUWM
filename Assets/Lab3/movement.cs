using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    
    public int speed = 5;
    int zmienKierunek = -1;
    void Start()
    {
        transform.position = new Vector3(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        var kordynatX = transform.position.x;
        if (kordynatX == 0 || kordynatX == 10)
        {
            zmienKierunek *= -1;
        }
        if(zmienKierunek == 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(10,0,0), speed*Time.deltaTime);
        }
        else if(zmienKierunek == -1)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(0,0,0), speed*Time.deltaTime);
        }
    }
}
