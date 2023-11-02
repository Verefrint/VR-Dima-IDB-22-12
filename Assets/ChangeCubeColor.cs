using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCubeColor : MonoBehaviour
{
    private Renderer cubeRenderer;  // Ññûëêà íà êîìïîíåíò Renderer êóáà

    private void Start()
    {
        cubeRenderer = GetComponent<Renderer>();  // Ïîëó÷àåì êîìïîíåíò Renderer êóáà
        cubeRenderer.material.color = Color.red;  // Óñòàíàâëèâàåì öâåò êóáà íà êðàñíûé
    }
}
