using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimator : MonoBehaviour
{
   public void getAnimatorDefeat()
    {
        this.GetComponent<Animator>().Play("Defeat");
    }
   public void getAnimatorWalk()
    {
        this.GetComponent<Animator>().Play("Walking");
    }
}
