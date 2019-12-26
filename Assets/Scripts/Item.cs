using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public GameObject explosion;
    public int Itemscore=10;
    Player player;

    void Start()
    {
        player = FindObjectOfType<Player>();
    }

    void OnTriggerEnter(Collider other)
    {
        Instantiate(explosion, transform.position, transform.rotation);
            player.AddScore(Itemscore);
            this.gameObject.SetActive(false);
   
    }
    
    void Update()
    {

    }

}
