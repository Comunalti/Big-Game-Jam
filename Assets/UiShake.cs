using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Serialization;

public class UiShake : MonoBehaviour
{
    public float time;

    [ContextMenu("Shake")]
    public void Shake()
    {
        transform.DOShakeScale(time);
        //transform.DOShakePosition(time);
    }
}
