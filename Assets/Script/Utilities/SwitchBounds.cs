using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class SwitchBounds : MonoBehaviour
{
    //TODO:�л���������ĵ���

    private void Start()
    {
        SwtichConfinerShape();
    }

    private void SwtichConfinerShape()
    {
        PolygonCollider2D confinerShape=GameObject.FindGameObjectWithTag("BoundsConfiner").GetComponent<PolygonCollider2D>(); 

        CinemachineConfiner confiner = GetComponent<CinemachineConfiner>();

        confiner.m_BoundingShape2D = confinerShape;

        confiner.InvalidatePathCache();
    }
}
