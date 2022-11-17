using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zad4lab6 : MonoBehaviour
{

  private zad2lab4 player;

  private void OnTriggerEnter(Collider other)
  {
    if (other.CompareTag("Player"))
    {
      player = other.GetComponent<zad2lab4>();
      player.velocity.y = Mathf.Sqrt(player.jumpHeight * -3.0f * player.gravity) * 3;
    }
  }
}
