using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotMove : MonoBehaviour
{
    /*Variables which will be used to store the update values of the bullet*/
    public float xUpdate = 0.0f;
    public float yUpdate = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        getUpdateVariables();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += new Vector3(xUpdate * Time.deltaTime, yUpdate * Time.deltaTime, 0.0f);
        
    }


    /*sets the y and x update variables according to the prefabs z position*/
    void getUpdateVariables()
    {
        int playerZ = (int)this.transform.position.z;
        if (playerZ == -1)
        {
            yUpdate = 3.0f;
        } 
        else if (playerZ == -2)
        {
            yUpdate = -3.0f;
        }
        else if (playerZ == -3)
        {
            xUpdate = -3.0f;
        }
        else 
        {
            xUpdate = 3.0f;
        }
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, -1.0f);
    }
}
