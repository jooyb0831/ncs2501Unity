using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    public GameObject[] players;
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        players = GameObject.FindGameObjectsWithTag("Player");

        for(int i = 0; i< players.Length; i++)
        {
            Debug.Log($"Player Number {i} is named {players[i].name}");
        }

        enemy = GameObject.FindWithTag("Enemy");
        Debug.Log($"Enemy is named {enemy.name}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
