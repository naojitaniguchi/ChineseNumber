using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeNumber : MonoBehaviour
{
    public int number = 0 ;
    public GameObject text;
    public GameObject image;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            number++;
            // number += 6;
            text.GetComponent<ChineseNumber>().setNumber(number);
            image.GetComponent<ChangeImage>().setNumber(number);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            number--;
            text.GetComponent<ChineseNumber>().setNumber(number);
            image.GetComponent<ChangeImage>().setNumber(number);
        }
    }
}
