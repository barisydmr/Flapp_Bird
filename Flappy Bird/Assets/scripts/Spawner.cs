using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Birdy BirdScript; 
    public GameObject Borular; // gameObject spawnlayaca��m�z i�in bu nesneyi olu�turduk
    public float height;
    public float time;
    void Start()
    {
        StartCoroutine(SpawnObject(time));
    }
    public IEnumerator SpawnObject(float time) //s�reli �eyler burada kullan�l�r
    {
        while (!BirdScript.isdead) //burada karakter �lmediyse
        {
             

            Instantiate(Borular, new Vector3(3, Random.Range(-height, height),0), Quaternion.identity);
            //quaternion bir rotasyon istiyor bu y�zden bizde kendi rotasyonunu kullans�n dedik
            //random.range �u i�e yarar girece�in de�erler aras�nda random bir de�er atar

            yield return new WaitForSeconds(time); //bir bekleme s�resine ihtiyac�m�z var o y�zden bu yaz�l�r
        }
        
    }
}
