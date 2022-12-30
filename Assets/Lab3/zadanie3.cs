using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadanie3 : MonoBehaviour
{
    public float speed = 5;
    int dirX = 1; int dirZ=0;
    void obrot()
    {
        transform.Rotate(0,90,0, Space.World);
    }
    void Update()
    {
        if (dirX ==1 && transform.position.x >= 10)
        {
            dirX = 0; dirZ =1; obrot();
        }
        else if (dirX == - 1 && transform.position.x <= 0)
        {
            dirX = 0; dirZ = -1; obrot();
        }
        else if (dirZ == 1  && transform.position.z >= 10)
        {
            dirX = -1; dirZ = 0; obrot();
        }
        else if (dirZ == -1 && transform.position.z <= 0)
        {
            dirX = 1; dirZ = 0; obrot();
        }
        transform.Translate( dirX * speed * Time.deltaTime, 0, dirZ * speed * Time.deltaTime,Space.World );
    }
}
