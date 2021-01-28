using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public Animator PlayerAnim;
    public Zippo Zippo;
    public void WakeUp()
    {
        PlayerAnim.SetTrigger("StandUp");
    }
}
