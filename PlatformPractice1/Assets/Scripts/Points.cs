using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Points : MonoBehaviour
{

    private TextMeshProUGUI textMesh;
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        textMesh.text = score.ToString();

    }


    public void AddPoints(int quantity)
    {
        score += quantity;
    }
}
