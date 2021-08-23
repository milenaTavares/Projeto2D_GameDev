using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    
    void Start()
    {
        Time.timeScale = 1;  // timeScale = 1, da play no jogo
    }
    public void restart()
    {
        SceneManager.LoadScene(0);
    }
}
