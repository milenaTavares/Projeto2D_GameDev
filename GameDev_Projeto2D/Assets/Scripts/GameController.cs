using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public int pontuacao;
    public Text textPontos;

    void Start()
    {
        Time.timeScale = 1;  // timeScale = 1, da play no jogo
    }
    public void restart()
    {
        SceneManager.LoadScene(0);
    }
}
