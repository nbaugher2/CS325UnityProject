using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player.transform.position = new Vector3(0.5f,0.5f,0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMoveUpdate();
        PlayerRotateUpdate();
    }
    
    /*Function which updates the player position based on input to WASD keys*/
    void PlayerMoveUpdate()
    {
        if (Input.GetKeyDown(KeyCode.A) && player.transform.position.x > -5.5f)
        {
            /*move left*/
            player.transform.position = new Vector3(-1.0f, 0.0f, 0.0f) + player.transform.position;
        }
        else if (Input.GetKeyDown(KeyCode.D) && player.transform.position.x < 6.5f)
        {
            /*move right*/
            player.transform.position = new Vector3(1.0f, 0.0f, 0.0f) + player.transform.position;
        }
        else if (Input.GetKeyDown(KeyCode.W) && player.transform.position.y < 2.5)
        {
            /*move up*/
            player.transform.position = new Vector3(0.0f, 1.0f, 0.0f) + player.transform.position;
        }
        else if (Input.GetKeyDown(KeyCode.S) && player.transform.position.y > -2.5)
        {
            player.transform.position = new Vector3(0.0f, -1.0f, 0.0f) + player.transform.position;
        }
    }

    /*function which rotates the player if necessary*/
    void PlayerRotateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            /*rotate left*/
            player.transform.Rotate(0.0f, 0.0f, 90.0f);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            /*rotate right*/
            player.transform.Rotate(0.0f, 0.0f, -90.0f);
        }
    }
}
