using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public string NEXT;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Enemy":
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
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
