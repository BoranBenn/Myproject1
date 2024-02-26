using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed = 10;
    public int counter = 0;
    public GameObject helloText;
    
    void Start()
    {
        print("Hello World");
        helloText.GetComponent<TextMeshPro>().text= "Hello World";
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0,0,1) * Time.deltaTime *speed);
    }
}
