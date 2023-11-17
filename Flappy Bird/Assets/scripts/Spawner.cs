using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Birdy BirdScript; 
    public GameObject Borular; // gameObject spawnlayacaðýmýz için bu nesneyi oluþturduk
    public float height;
    public float time;
    void Start()
    {
        StartCoroutine(SpawnObject(time));
    }
    public IEnumerator SpawnObject(float time) //süreli þeyler burada kullanýlýr
    {
        while (!BirdScript.isdead) //burada karakter ölmediyse
        {
             

            Instantiate(Borular, new Vector3(3, Random.Range(-height, height),0), Quaternion.identity);
            //quaternion bir rotasyon istiyor bu yüzden bizde kendi rotasyonunu kullansýn dedik
            //random.range þu iþe yarar gireceðin deðerler arasýnda random bir deðer atar

            yield return new WaitForSeconds(time); //bir bekleme süresine ihtiyacýmýz var o yüzden bu yazýlýr
        }
        
    }
}
