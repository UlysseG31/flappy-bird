using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pipe : MonoBehaviour
{
    public GameObject GameO;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(-0.005f, 0f, 0f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<player>() != null)
        {
            //Kill player
            collision.gameObject.SetActive(false);
            GameO.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
