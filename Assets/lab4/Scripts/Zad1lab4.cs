using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = System.Random;

public class Zad1lab4 : MonoBehaviour
{
    List<Vector3> positions = new List<Vector3>();
    public float delay = 3.0f;
    int objectCounter = 0;
    // obiekt do generowania
    public GameObject block;
    public List<Material> materials;

    public int amount = 10;

    void Start()
    {
        // w momecie uruchomienia generuje 10 kostek w losowych miejscach
        List<int> pozycje_x = new List<int>(Enumerable.Range(0 + (int)GetComponent<Transform>().position.x, 20).OrderBy(x => Guid.NewGuid()).Take(amount));
        List<int> pozycje_z = new List<int>(Enumerable.Range(0 + (int)GetComponent<Transform>().position.z, 20).OrderBy(x => Guid.NewGuid()).Take(amount));

        for (int i = 0; i < 10; i++)
        {
            this.positions.Add(new Vector3(pozycje_x[i], 5, pozycje_z[i]));
        }
        foreach (Vector3 elem in positions)
        {
            Debug.Log(elem);
        }
        // uruchamiamy coroutine
        StartCoroutine(GenerujObiekt());
    }

    void Update()
    {

    }

    IEnumerator GenerujObiekt()
    {
        Debug.Log("wywo�ano coroutine");
        foreach (Vector3 pos in positions)
        {
            Random random = new Random();
            this.block.GetComponent<Renderer>().material = materials[random.Next(materials.Count)];
            Instantiate(this.block, this.positions.ElementAt(this.objectCounter++), Quaternion.identity);
            
            yield return new WaitForSeconds(this.delay);
        }
        // zatrzymujemy coroutine
        StopCoroutine(GenerujObiekt());
    }
}