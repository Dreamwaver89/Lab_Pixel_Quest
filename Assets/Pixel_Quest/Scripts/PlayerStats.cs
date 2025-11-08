using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerStats : MonoBehaviour
{
    public string NEXT;
    private int coinCounter = 0;
    private int _health = 3;
    private int _maxHealth = 3;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Enemy":
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                    break;

                }

            case "Health":
                {
                    _health++;
                    Destroy(collision.gameObject);
                    break;
                }
            case "Coin":
                {
                    coinCounter++;
                    Destroy(collision.gameObject);
                    break;
                }
            case "Finish":
                {
                    SceneManager.LoadScene(NEXT);
                    break;
                }
        }
    }
}
