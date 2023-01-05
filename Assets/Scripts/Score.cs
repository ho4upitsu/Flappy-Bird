using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI ScoreText;
    public static int _score = 0;
    
    void Start()
    {
        _score = 0;
    }
    void Update()
    {
        ScoreText.text = _score.ToString();
    }
}
