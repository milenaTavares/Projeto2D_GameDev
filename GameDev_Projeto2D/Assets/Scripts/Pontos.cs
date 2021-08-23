using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pontos : MonoBehaviour
{
    public GameController controller;

    void Start()
    {
        controller = FindObjectOfType<GameController>();
    }

    //Adiciona um ponto sempre que o personagem colidir com o colisor localizado entre os dois canos
    private void OnTriggerEnter2D(Collider2D colisor)
    {
        controller.pontuacao++;
        controller.textPontos.text = controller.pontuacao.ToString();
    }
}
