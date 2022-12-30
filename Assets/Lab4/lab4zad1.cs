using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class lab4zad1 : MonoBehaviour
{
List<Vector3> positions = new List<Vector3>();
    public float delay = 3.0f;
    int objectCounter = 0;
    public GameObject block;
    public int objectCount;
    public List<Material> materials = new List<Material>();

    void Start()
    {
        //List<int> pozycje_x = new List<int>(Enumerable.Range(-10, 20).OrderBy(x => Guid.NewGuid()).Take(10));
        //List<int> pozycje_z = new List<int>(Enumerable.Range(-10, 20).OrderBy(x => Guid.NewGuid()).Take(10));

        List<int> pozycje_x = new List<int>();
        List<int> pozycje_z = new List<int>();
        for (int i = 0; i < objectCount; i++)
        {
            pozycje_x.Add(UnityEngine.Random.Range(-10, 10));
            pozycje_z.Add(UnityEngine.Random.Range(-10, 10));
        }

        for (int i = 0; i < objectCount; i++)
        {
            this.positions.Add(new Vector3(transform.position.x + pozycje_x[i], 0.5f, transform.position.z + pozycje_z[i]));
        }
        foreach (Vector3 elem in positions)
        {
            Debug.Log(elem);
        }
        StartCoroutine(GenerujObiekt());
    }

    IEnumerator GenerujObiekt()
    {
        Debug.Log("wywo³ano coroutine");
        foreach (Vector3 pos in positions)
        {
            GameObject b = block;
            block.GetComponent<MeshRenderer>().material = materials[UnityEngine.Random.Range(0, materials.Count)];
            Instantiate(b, this.positions.ElementAt(this.objectCounter++), Quaternion.identity);
            yield return new WaitForSeconds(this.delay);
        }
        StopCoroutine(GenerujObiekt());
    }
}
