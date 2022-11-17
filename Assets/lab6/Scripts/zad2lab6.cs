using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zad2lab6 : MonoBehaviour
{
  private Vector3 openPosition;
  private Vector3 closePosition;
  private Transform player;

  private bool doorOpen;

  void Start()
  {
    closePosition = transform.position;
    closePosition.x += transform.localScale.x;
    player = GameObject.FindGameObjectWithTag("Player").transform;
  }

  void Update()
  {
    if (Vector3.Distance(transform.position, player.position) < 1.5f && doorOpen == false)
    {
      transform.position = new Vector3(transform.position.x+1, transform.position.y, transform.position.z);
      doorOpen = true;
    }
    if (Vector3.Distance(transform.position, player.position) >= 1.5f && doorOpen == true)
    {
      doorOpen = false;
      transform.position = new Vector3(transform.position.x-1, transform.position.y, transform.position.z);
    }
  }
}
