using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed;
    private void Start()
    {
        Destroy(gameObject, 8); //start ta �a��r ve 5 saniye sonra yok et borular�
    }

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
