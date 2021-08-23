using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BemTeVi : MonoBehaviour
{
    float velocidade = 1f;
    private Rigidbody2D rb;
    public GameObject gameOver;

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

    //Ativa o objeto Game Over quando o personagem bate em algum obstaculo
    void OnCollisionEnter2D(Collision2D colisor)
    {
        gameOver.SetActive(true);
        Time.timeScale = 0; //pausar o jogo
    }
}
