using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 2.0f;
      Vector3 moveX = new Vector3(-1, 0, 0);

    // Update is called once per frame
    void Update()
    {
        transform.position += moveX * speed * Time.deltaTime;
    }
}
