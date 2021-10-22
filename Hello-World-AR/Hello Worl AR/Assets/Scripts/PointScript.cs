using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointScript : MonoBehaviour
{
  public GameObject particleSystem;


  private void OnTriggerEnter(Collider other)
  {
    Instantiate(particleSystem, transform.position, Quaternion.identity);
  }
}
