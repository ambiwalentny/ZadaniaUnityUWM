using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadanie5 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Cube;
    public int ileObiektow = 10;
    int[] zajeteX = new int[10];
    int[] zajeteZ = new int[10];
    bool powtorka = false;
    // Update is called once per frame
    void Start()
    {
        Spawner();
    }
    void Spawner()
    {
        for(int x = 0; x < ileObiektow; x ++)
        {
            int wspX = Random.Range(-9,10); int wspZ = Random.Range(-9,10);
            
            zajeteX[x] = wspX; zajeteZ[x] = wspZ; 
            for(int y = 0; y < x; y ++)
            {
                if(wspX == zajeteX[y] && wspZ == zajeteZ[y])
                {
                    powtorka = true;
                }
            }
            Vector3 spawnPlace = new Vector3(wspX,5, wspZ);
            if(!powtorka)
            {Instantiate(Cube, spawnPlace, Quaternion.identity);}
            else{ileObiektow++;} //gdyby współrzędne się powtórzyły zwiększam liczbę obiektó aby pętla miała jedno dodatkowe przejście
            
        }
    }
}
    