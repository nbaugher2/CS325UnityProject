using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldCollision : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Zombie")
        {
            other.gameObject.transform.position = Vector3.MoveTowards(other.gameObject.transform.position, transform.position, 1.0f * Time.deltaTime);
        }
    }
}
