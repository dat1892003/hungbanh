using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    Game check;
    private void Start()
    {
        check = FindObjectOfType<Game>();
    }
    private void OnCollisionEnter2D(Collision2D collision) // bat va cham voi Tag 
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            check.tangdiem();
        } 
    }
    private void OnTriggerEnter2D(Collider2D collision) // bat va cham voi Tag xuyen qua
    {
        if (collision.gameObject.CompareTag("DeathZone"))
        {
            Destroy(gameObject);
            check.GameOver(true);
        }
    }
}
