using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BemTeVi : MonoBehaviour
{
    [SerializeField]
    float velocidade = 1f;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //Se clicar com o botão esquerdo do mouse
        if (Input.GetMouseButton(0))
        {
            //Adiciona força/velocidade para cima no passarinho
            rb.velocity = Vector2.up * velocidade;
        }        
    }
}
