using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject Coins;


    public void RestartGame()
    {

            player.transform.position.Set(0, 1, 0);
            Coins.SetActive(true);
       
    }
    
}
