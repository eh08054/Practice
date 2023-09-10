using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pipe;
    float timer = 0;
    public float timeDiff = 1.5f;
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 1.0f * timeDiff)
        {
            GameObject pipePrefab = Instantiate(pipe);
            pipePrefab.transform.position = new Vector3(6, Random.Range(-3.5f, 2.5f), 0);
            timer = 0;
            Destroy(pipePrefab, 10.0f);
        }
    }
}
