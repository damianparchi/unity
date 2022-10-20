using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3Zad5 : MonoBehaviour
{
    public GameObject cube;

    List<(int,int)> list = new List<(int,int)>();

    void Start()
    {
        for (int n = -5; n < 5; n++)
        {
            for (int m = -5; m < 5; m++)
            {
                list.Add((n, m));
            }
                
        }

        for(int n = 0; n < 9; n++)
        {
            int index = Random.Range(0, list.Count - 1);
            Instantiate(cube, new Vector3(list[index].Item1, 1, list[index].Item2), Quaternion.identity);
            list.Remove(list[index]);
        }
    }
}
