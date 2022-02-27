using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickitem : MonoBehaviour
{
    private void OnCollisionEnter(Collision wall)
    {
        if(wall.gameObject.tag.Equals("Wall"))
        {
            Debug.Log("ชนกำเเพง");
        }
    }
}
