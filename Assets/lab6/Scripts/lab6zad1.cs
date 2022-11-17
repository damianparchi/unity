using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lab6zad1 : MonoBehaviour
{
  public Vector3 target;
  private Vector3 targetPosition;
  private List<Vector3> positions = new List<Vector3>();

  public float speed = 5;
  private bool Move;

  void Start()
  {
    positions.Add(transform.position);
    positions.Add(target);
  }

  void FixedUpdate()
  {
    if (Move == true && transform.position == targetPosition)
    {
      Move = false;
    }

    if (Move == true)
    {
      transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }
  }

  private void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.CompareTag("Player"))
    {
      other.transform.parent = transform;
      if (transform.position == positions[0])
      {
        targetPosition = positions[1];
      }
      else if (transform.position == positions[1])
      {
        targetPosition = positions[0];
      }
      Move = true;
    }
  }

  private void OnTriggerExit(Collider other)
  {
    other.transform.parent = null;
  }
}
