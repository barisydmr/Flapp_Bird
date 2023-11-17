using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birdy : MonoBehaviour
{

    public bool isdead; //otomatik olarak false de�erinde gelir //ku� �lene kadar devam etmesi i�in kontrol ettirmemiz gerekir
    public float velocity = 1f;
    public Rigidbody2D rb2D;
    // Sadece 1 kez oyun ba�lad���nda �al��t�r�lacak olan kod (void Start())
    public GameManager managerGame;
    // Bu kod her framede �al��t�r�l�r
    public GameObject DeathScreen;
    public GameObject StartArea;
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //bu getMouseButtonDown -> sadece bir kez t�klamam�z� sa�lar / down eklemezsen bas�l� tutman� ister
        {
            //Havada ku�u s��rat�r her sol click e bast���m�zda
            rb2D.velocity = Vector2.up * velocity; //burada ne kadar ekrana butona t�klarsak girdi�imiz de�er ile �arp�p sonucu ekranda g�sterecek
        }
    }


    private void Start()
    {
        Time.timeScale = 1;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "scoreArea") //burada ise skoru yaz�yoruz
        {
            managerGame.updateScore();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeathArea") //burada e�er �ld�ysek oyunu durdur ve �l�m ekran�n� kar��m�za getir diyoruz
        {
            isdead = true;
            Time.timeScale = 0;

            DeathScreen.SetActive(true);
        }
        else if(collision.gameObject.tag == "StartScreen") //burada ise e�er oyun ba�lang�� ekran�ndaysa oyun dursun ama ekranda ba�lang�� ekran� kals�n
        {
            isdead = false;
            Time.timeScale = 0;

            StartArea.SetActive(true);
        
        }
    }


}
