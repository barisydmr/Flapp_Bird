using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    
    public void PlayButton()
    {
        SceneManager.LoadScene("FlappyBird"); //burada butona t�kland���nda Flappy Bird sahnesine git diyoruzs
    }

 
}
