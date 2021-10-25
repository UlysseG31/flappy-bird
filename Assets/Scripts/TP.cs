using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP : MonoBehaviour
{
    public Vector3 c_initTPValue;
    private void OnTriggerEnter2D(Collider2D collision)
    {
            Debug.Log("yay");
            Pipe f_pipe = collision.GetComponent<Pipe>();
            collision.transform.position = collision.transform.position + c_initTPValue;


    }
}
