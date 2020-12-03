using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChineseNumber : MonoBehaviour
{
    public string[] chNums;
    public int num;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // gameObject.GetComponent<Text>().text = chNums[num];        
    }

    public void setNumber( int n)
    {
        num = n;
        gameObject.GetComponent<Text>().text = chNums[num];
    }

}
