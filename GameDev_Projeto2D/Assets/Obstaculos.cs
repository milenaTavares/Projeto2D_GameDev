using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculos : MonoBehaviour
{
    public float velocidade;

    // Update is called once per frame
    void Update()
    {
        //Moviemnto Horizontal dos obstaculos
        transform.position += Vector3.left * velocidade * Time.deltaTime;
    }
}
