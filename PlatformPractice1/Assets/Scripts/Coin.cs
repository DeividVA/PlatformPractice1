using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Coin : MonoBehaviour
{
    [SerializeField] private int Quantity;
    [SerializeField] private Points Hud;

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            Hud.AddPoints(Quantity);
            Destroy(this.gameObject);
        }
    }
    //TODO: Have the prefab accepting Hud text. Otherwise you have to add it to every object
}


