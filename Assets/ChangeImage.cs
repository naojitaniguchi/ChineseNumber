using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImage : MonoBehaviour
{
    public Sprite[] sprites;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setNumber(int n)
    {
        gameObject.GetComponent<Image>().sprite = sprites[n];
    }
}
