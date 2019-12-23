using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public int Itemscore=10;
    ScoreManager score;

    void Start()
    {
        score = GetComponent<ScoreManager>();
    }

    void OnTriggerEnter(Collider other)
    {
       score.setScore(Itemscore);
    }
    
    void Update()
    {

    }

}
