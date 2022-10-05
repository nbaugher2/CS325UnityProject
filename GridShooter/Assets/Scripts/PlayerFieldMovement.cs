using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFieldMovement : MonoBehaviour
{
    public GameObject playerField;

    // Start is called before the first frame update
    void Start()
    {
        playerField.transform.position = new Vector3(0.5f, 0.5f, -1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerFieldMoveUpdate())
        {

        }
    }

    /*Function which updates the player position based on input to WASD keys*/
    bool PlayerFieldMoveUpdate()
    {
        if (Input.GetKeyDown(KeyCode.A) && playerField.transform.position.x > -5.5f)
        {
            /*move left*/
            playerField.transform.position = new Vector3(-1.0f, 0.0f, 0.0f) + playerField.transform.position;
            return true;
        }
        else if (Input.GetKeyDown(KeyCode.D) && playerField.transform.position.x < 6.5f)
        {
            /*move right*/
            playerField.transform.position = new Vector3(1.0f, 0.0f, 0.0f) + playerField.transform.position;
            return true;
        }
        else if (Input.GetKeyDown(KeyCode.W) && playerField.transform.position.y < 2.5)
        {
            /*move up*/
            playerField.transform.position = new Vector3(0.0f, 1.0f, 0.0f) + playerField.transform.position;
            return true;
        }
        else if (Input.GetKeyDown(KeyCode.S) && playerField.transform.position.y > -2.5)
        {
            playerField.transform.position = new Vector3(0.0f, -1.0f, 0.0f) + playerField.transform.position;
            return true;
        }
        return false;
    }

}
