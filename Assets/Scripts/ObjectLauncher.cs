using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectLauncher : MonoBehaviour
{
    public GameObject prefab;
    public float positionOffset = 2;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //Instantiate sirve para duplicar objetos
            GameObject instance = Instantiate(prefab, transform.position + transform.forward * positionOffset, transform.rotation);
            //Destroy sirve para borrar objetos
            Destroy(instance, 2.5f);
        }
    }
}
