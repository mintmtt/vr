using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    // Start is called before the first frame update
    public void getGray()
    {
        this.GetComponent<Renderer>().material.color = Color.grey;
    }
    public void getBlue()
    {
        this.GetComponent<Renderer>().material.color = Color.blue;
    }
    public void getGreen()
    {
        this.GetComponent<Renderer>().material.color = Color.green;
    }
}
