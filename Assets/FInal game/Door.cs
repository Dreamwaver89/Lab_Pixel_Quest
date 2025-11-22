using Unity.VisualScripting;
using UnityEngine;

public class ClickToShow : MonoBehaviour
{
    public GameObject objectToShow; // Assign in Inspector
    private float displayDuration = 2f;
    float batterylife;



    void OnMouseDown()
    {
        if (objectToShow != null)
        {
            StartCoroutine(ShowObjectTemporarily());
        }
    }

    private System.Collections.IEnumerator ShowObjectTemporarily()
    {
        objectToShow.SetActive(true);
        yield return new WaitForSeconds(displayDuration);
        objectToShow.SetActive(false);
    }
}


