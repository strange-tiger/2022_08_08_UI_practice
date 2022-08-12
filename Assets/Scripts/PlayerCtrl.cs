using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets;

public class PlayerCtrl : MonoBehaviour, ITargetable
{
    public void Damaged()
    {
        Debug.Log("공격을 받았다");
    }
}
