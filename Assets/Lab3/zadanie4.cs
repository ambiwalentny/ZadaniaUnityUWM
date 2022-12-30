using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadanie4 : MonoBehaviour
{
    public float speed = 5f;
    GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float pion = Input.GetAxis("Vertical");
        float poziom = Input.GetAxis("Horizontal");
        Vector3 move = new Vector3(poziom, 0, pion);

        player.transform.position += move*Time.deltaTime*speed;
        
    }
}
