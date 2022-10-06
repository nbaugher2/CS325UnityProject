using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedicDeSpawn : MonoBehaviour
{
    public AudioClip deathSound;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Pellet")
        {
            AudioSource.PlayClipAtPoint(deathSound, new Vector3(-.55f,-.31f,-1f), 100.0f);
            Destroy(gameObject);
        }
    }

}
