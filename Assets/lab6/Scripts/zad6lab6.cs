using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zad6lab6 : MonoBehaviour
{
  private void OnControllerColliderHit(ControllerColliderHit hit)
  {
    if (hit.gameObject.CompareTag("Obstacle"))
    {
      Debug.Log("Dotknięto przeszkody!");
    }
  }
}
