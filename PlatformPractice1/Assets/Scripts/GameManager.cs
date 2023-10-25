using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    // Singleton implementation
    public static GameManager Instance;

    private int _coins;

    // Start is called before the first frame update
    void Start()
    {
        if (Instance == null)
        {
            Instance = this;
            _coins = 0;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddCoins(int quantity)
    {
        _coins += quantity;
    }

    public int GetCoins() { return _coins; }
}
