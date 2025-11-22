using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTimer : MonoBehaviour
{
    public float delayInSeconds = 5f; // Set the timer duration in Inspector
    public string sceneToLoad = "NextScene"; // Replace with your scene name

    void Start()
    {
        StartCoroutine(LoadSceneAfterDelay());
    }

    private System.Collections.IEnumerator LoadSceneAfterDelay()
    {
        yield return new WaitForSeconds(delayInSeconds);
        SceneManager.LoadScene(sceneToLoad);
    }
}

