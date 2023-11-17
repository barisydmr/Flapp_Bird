using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birdy : MonoBehaviour
{

    public bool isdead; //otomatik olarak false deðerinde gelir //kuþ ölene kadar devam etmesi için kontrol ettirmemiz gerekir
    public float velocity = 1f;
    public Rigidbody2D rb2D;
    // Sadece 1 kez oyun baþladýðýnda çalýþtýrýlacak olan kod (void Start())
    public GameManager managerGame;
    // Bu kod her framede çalýþtýrýlýr
    public GameObject DeathScreen;
    public GameObject StartArea;
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //bu getMouseButtonDown -> sadece bir kez týklamamýzý saðlar / down eklemezsen basýlý tutmaný ister
        {
            //Havada kuþu sýçratýr her sol click e bastýðýmýzda
            rb2D.velocity = Vector2.up * velocity; //burada ne kadar ekrana butona týklarsak girdiðimiz deðer ile çarpýp sonucu ekranda gösterecek
        }
    }


    private void Start()
    {
        Time.timeScale = 1;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "scoreArea") //burada ise skoru yazýyoruz
        {
            managerGame.updateScore();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeathArea") //burada eðer öldüysek oyunu durdur ve ölüm ekranýný karþýmýza getir diyoruz
        {
            isdead = true;
            Time.timeScale = 0;

            DeathScreen.SetActive(true);
        }
        else if(collision.gameObject.tag == "StartScreen") //burada ise eðer oyun baþlangýç ekranýndaysa oyun dursun ama ekranda baþlangýç ekraný kalsýn
        {
            isdead = false;
            Time.timeScale = 0;

            StartArea.SetActive(true);
        
        }
    }


}
