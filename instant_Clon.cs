using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instant_Clon : MonoBehaviour
{
    public GameObject klonlanacakNesne;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(klonlanacakNesne, transform.position, Quaternion.identity); //kopyalanacakNesne, pozisyon, açı
            //Quaternion.identity = açılarının sıfır olmasını belirtir
        }
    }
}
