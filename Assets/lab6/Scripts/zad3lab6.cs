using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zad3lab6 : MonoBehaviour
{
  public List<Vector3> positions = new List<Vector3>();
  private int dir = 1;
  private int nextPosIndex = 0;

  public float speed;
  private bool Move;

  void Start()
  {
    positions.Insert(0, transform.position);
  }

  void FixedUpdate()
  {
    if (Move == true && transform.position == positions[nextPosIndex])
    {
      if (nextPosIndex + 1 == positions.Count)
      {
        Move = false;
        dir = -1;
      }

      if (nextPosIndex == 0)
      {
        Move = false;
        dir = 1;
      }
      nextPosIndex += dir;
    }

    if (Move == true)
    {
      transform.position = Vector3.MoveTowards(transform.position, positions[nextPosIndex], speed * Time.deltaTime);
    }
  }

  private void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.CompareTag("Player"))
    {
      other.transform.parent = transform;
      Move = true;
    }
  }

  private void OnTriggerExit(Collider other)
  {
    other.transform.parent = null;
  }
}
