using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onCollision_onTrigger : MonoBehaviour
{
    public float yatayHiz;
    void Update()
    {
        float yatayKontrol = Input.GetAxis("Horizontal") * yatayHiz;
        transform.Translate(yatayKontrol * Time.deltaTime, 0f, 0f);
    }

    //Temaslar - çarpışmalar 2'ye ayrılır
    //-Sert Çarpışma (Collision(içinden geçmez sadece çarpar))
    //-Yumuşak Çarpışma (Trigger(içinden geçer)) trigger = tetikleyici

    //onCollisionEnter = Çarptığında
    //onTriggerEnter = İçine girdiğinde

/*Sert Çarpışma*/
    private void OnCollisionEnter(Collision temas)//objeye temas ettiğinde çalışır
    {
        Debug.Log("Temas Etti");
    }
    private void OnCollisionStay(Collision temas)//objeye temas etme olayı devam ettiği sürece çalışır
    {
        Debug.Log("Temas Etmeye Devam ediyor");
    }
    private void OnCollisionExit(Collision temas)//objeye temas bittiğinde çalışır
    {
        Debug.Log("Temas Bitti");
    }
/*Sert Çarpışma*/


/*Yumuşak Çarpışma*/ //is trigger açık olmalı en azn bir temas edende
    private void OnTriggerEnter(Collider temas)//objeye temas ettiğinde çalışır   //2D olunca "private void OnTriggerEnter2D(Collider2D temas)" Şeklinde yazılmalı
    {
        Debug.Log("Obje içine girdi");
    }
    private void OnTriggerStay(Collider temas)//objeye temas etme olayı devam ettiği sürece çalışır
    {
        Debug.Log("Obje içinde");
    }
    private void OnTriggerExit(Collider temas)//objeye temas bittiğinde çalışır
    {
        Debug.Log("Obje çıktı");
    }
/*Yumuşak Çarpışma*/

}
