using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerarObstaculos : MonoBehaviour
{
    public GameObject obstaculo; //Referenciar o objeto que contém os obstáculos
    public float altura;
    public float maxTime;        //Tempo máximo entre a criação dos obstaculos
    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newObstaculo = Instantiate(obstaculo);
        newObstaculo.transform.position = transform.position + new Vector3(0, Random.Range(-altura, altura), 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        //gerar cópias dos obstaculos com alturas aleatórias em um tempo determinado
        if (timer > maxTime)
        {
            GameObject newObstaculo = Instantiate(obstaculo);
            newObstaculo.transform.position = transform.position + new Vector3(0, Random.Range(-altura, altura), 0);
            Destroy(newObstaculo, 20f); //Destrói os canos que já passaram pela cena depois de 20s
            timer = 0;
        }

        timer += Time.deltaTime;

        
    }
}
