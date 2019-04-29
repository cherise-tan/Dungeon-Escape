using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour {

    [SerializeField] int pointsForCoinPickup = 100;
    [SerializeField] AudioClip coinPickUpSFX;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        CapsuleCollider2D playerCollider = FindObjectOfType<Player>().GetComponent<CapsuleCollider2D>();

        if (collision == playerCollider)
        {
            FindObjectOfType<GameSession>().AddToScore(pointsForCoinPickup);

            AudioSource.PlayClipAtPoint(coinPickUpSFX, Camera.main.transform.position);
            Destroy(gameObject);
        }
    }
}
