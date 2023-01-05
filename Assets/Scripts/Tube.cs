using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Tube : MonoBehaviour
{
    [SerializeField] public float speed;
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
    
}
