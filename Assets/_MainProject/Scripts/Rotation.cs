using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    // Attribut 

    [SerializeField] private float _vitesseRotationY = 0.5f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, _vitesseRotationY, 0f);
    }
}
