using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedicSpawner : MonoBehaviour
{
    private IEnumerator spawnMedicHolder;
    private IEnumerator increaseDifficultyHolder;
    public GameObject medicPrefab;
    float spawnTime = 5.0f;
    public float xMax;
    public float xMin;
    public float yMax;
    public float yMin;

    // Start is called before the first frame update
    void Start()
    {
        spawnMedicHolder = spawnMedic();
        increaseDifficultyHolder = increaseDifficulty();
        StartCoroutine(increaseDifficultyHolder);
        StartCoroutine(spawnMedicHolder);
    }

    private IEnumerator spawnMedic()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTime);
            Instantiate(medicPrefab, new Vector3(Random.Range(xMin,xMax), Random.Range(yMin,yMax),-1.0f), Quaternion.identity);
        }
    }

    private IEnumerator increaseDifficulty()
    {
        while (true)
        {
            if (spawnTime > .75f)
            {
                yield return new WaitForSeconds(10.0f);
                spawnTime -= .5f;
            }
            else
            {
                yield break;
            }
        }
    }

}
