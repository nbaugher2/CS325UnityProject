using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public void SceneSwap(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
