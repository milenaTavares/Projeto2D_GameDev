using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerarObstaculos : MonoBehaviour
{
    public GameObject obstaculo; //Referenciar o objeto que cont�m os obst�culos
    public float altura;
    public float maxTime;        //Tempo m�ximo entre a cria��o dos obstaculos
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
        //gerar c�pias dos obstaculos com alturas aleat�rias em um tempo determinado
        if (timer > maxTime)
        {
            GameObject newObstaculo = Instantiate(obstaculo);
            newObstaculo.transform.position = transform.position + new Vector3(0, Random.Range(-altura, altura), 0);
            Destroy(newObstaculo, 20f); //Destr�i os canos que j� passaram pela cena depois de 20s
            timer = 0;
        }

        timer += Time.deltaTime;

        
    }
}
