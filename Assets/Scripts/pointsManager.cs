using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointsManager : MonoBehaviour
{
    public int Points = 0;
    public Text text_points;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text_points.text = "" + Points;
    }
}
