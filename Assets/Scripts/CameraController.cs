using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Update is called once per frame
   [SerializeField]  private Transform player;
   private  void Update()
    {
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);  
    }
}
