using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class input : MonoBehaviour
{
    public float yatayHiz, dikeyHiz, mouseYatayHiz, mouseDikeyHiz;
    void Start()
    {
        
    }

    void Update()
    {
    /*GetAxis Yatay-Dikey kontroller*/

        float yatayKontrol = Input.GetAxis("Horizontal") * yatayHiz; //getAxislerin varsayılan hızı 1 ve 0 arasında olduğu için çok yavaş harkeet ediyor
        float dikeyKontrol = Input.GetAxis("Vertical") * dikeyHiz;

        transform.Translate(yatayKontrol * Time.deltaTime, dikeyKontrol * Time.deltaTime, 0f); //x, y, z Hareketi - Time.deltaTime saniyeyle çarpar eğer kullanmazsak UPdatede çalıştığı için her bilgisayarda kare hızı farklı olduğu için farklı hızlarda çalışır o yüzden saniyeye göre hızını sağlıyoruz
        //transform = bir nesnenin pozisyon lokasyon ve açısal değerlerini barındıran componenttir
        //Time.deltaTime = var olan zaman Saniye demektir

    /*GetAxis Yatay-Dikey kontroller*/

        
    /*GetAxis Mouse Yatay-Dikey kontroller*/

        float yatayMouseKontrol = Input.GetAxis("Mouse X") * mouseYatayHiz;
        float dikeyMouseKontrol = Input.GetAxis("Mouse Y") * mouseDikeyHiz;

        transform.Translate(yatayMouseKontrol * Time.deltaTime, dikeyMouseKontrol * Time.deltaTime, 0f);

    /*GetAxis Mouse Yatay-Dikey kontroller*/

    /*Mousedan girdi almak*/

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Sol Fare Tuşuna Basıldı");
        }
        if (Input.GetMouseButtonUp(1))
        {
            Debug.Log("Sağ Fare Tuşuna basılıp el çekildi");
        }
        if (Input.GetMouseButton(2))
        {
            Debug.Log("Orta Tekerlek Tuşuna basılı tutuluyor");
        }

    /*Mousedan girdi almak*/

    /*------------------------------------------------------*/

    /*Klavyeden girdi almak*/

        if (Input.GetKeyDown(KeyCode.Space))//Tuşa basıldığı anda bir kere çalışır
        {
            Debug.Log("Boşluk Tuşuna Basıldı");
        }


        if (Input.GetKeyUp(KeyCode.Space))//Tuşa basıp tuştan kaldırıldıktan sonra çalışır
        {
            Debug.Log("Boşluk tuşuna basılıp el çekildi");
        }


        if (Input.GetKey(KeyCode.Space))//Tuşa basıldığı sürece çalışır
        {
            Debug.Log("Boşluk tışına basılı tutuluyor");
        }


        if (Input.anyKey) //Herhangi bir tuşa basılınca
        {
            Debug.Log("Herhangi bir tuşa basıldı");
        }

        if (Input.anyKeyDown)//Herhangi bir tuşa basılı tutuldukça çalışır
        {
            Debug.Log("Herhangi bir tuşa basılı tutuluyor");
        }

    /*Klavyeden girdi almak*/

    }
}
