using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotDeSpawn : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag != "PlayerTag" && other.gameObject.tag != "PlayerField" && other.gameObject.tag != "Pellet")
        {
            Destroy(gameObject);
        }
    }
   
}
