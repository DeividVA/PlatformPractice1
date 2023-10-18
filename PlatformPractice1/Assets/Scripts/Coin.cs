using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coin : MonoBehaviour
{

    [SerializeField] private GameObject shatterEffect;
    private TextMeshPro _text;

    // Start is called before the first frame update
    void Start()
    {
        _text = GetComponent<TextMeshPro>();

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {

            Destroy(this.gameObject);
            //habría que sumar a la cuenta de monedas text++
        }
    }

}


