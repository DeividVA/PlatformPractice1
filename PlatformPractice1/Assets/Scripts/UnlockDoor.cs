using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockDoor : MonoBehaviour
{
    private SpriteRenderer _sprite;
    private int _actualPoints = GameManager.Instance.GetCoins();

    // Start is called before the first frame update
    void Start()
    {
        _sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
       if (_actualPoints >= 7)
        {
            _sprite.color = Color.green;
            //Destroy(this.gameObject);
        }

    }
}
