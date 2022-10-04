using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject player;
    public GameObject bulletPrefab;
    private int zStore;

    // Start is called before the first frame update
    void Start()
    {
        player.transform.position = new Vector3(0.5f,0.5f,-1.0f);
        zStore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerMoveUpdate() || PlayerRotateUpdate() || PlayerShotUpdate())
        {
            
        } 
    }
    
    /*Function which updates the player position based on input to WASD keys*/
    bool PlayerMoveUpdate()
    {
        if (Input.GetKeyDown(KeyCode.A) && player.transform.position.x > -5.5f)
        {
            /*move left*/
            player.transform.position = new Vector3(-1.0f, 0.0f, 0.0f) + player.transform.position;
            return true;
        }
        else if (Input.GetKeyDown(KeyCode.D) && player.transform.position.x < 6.5f)
        {
            /*move right*/
            player.transform.position = new Vector3(1.0f, 0.0f, 0.0f) + player.transform.position;
            return true;
        }
        else if (Input.GetKeyDown(KeyCode.W) && player.transform.position.y < 2.5)
        {
            /*move up*/
            player.transform.position = new Vector3(0.0f, 1.0f, 0.0f) + player.transform.position;
            return true;
        }
        else if (Input.GetKeyDown(KeyCode.S) && player.transform.position.y > -2.5)
        {
            player.transform.position = new Vector3(0.0f, -1.0f, 0.0f) + player.transform.position;
            return true;
        }
        return false;
    }

    /*function which rotates the player if necessary*/
    bool PlayerRotateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            /*rotate left*/
            player.transform.eulerAngles += new Vector3(0.0f, 0.0f, 90.0f);
            zStore -= 1;
            return true;
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            /*rotate right*/
            player.transform.eulerAngles += new Vector3(0.0f, 0.0f, -90.0f);
            zStore += 1;
            return true;
        }
        return false; 
    }

    bool PlayerShotUpdate()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            float x = player.transform.position.x;
            float y = player.transform.position.y;
            float z = 0.0f;
            Debug.Log(zStore);
            if (zStore % 4 == 0)
            {
                z = -1.0f;
            }
            else if (zStore % 4 == 2){
                z = -2.0f;
            }
            else if (zStore % 4 == 3)
            {
                z = -3.0f;
            }
            else if (zStore % 4 == 1)
            {
                z = -4.0f;
            }
            Instantiate(bulletPrefab, new Vector3(x, y, z), Quaternion.identity);
            return true;
        }
        return false;
    }
}
