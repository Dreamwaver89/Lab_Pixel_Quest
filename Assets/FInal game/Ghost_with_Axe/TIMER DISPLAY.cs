using UnityEngine;
using UnityEngine.UI; // Use TMPro if using TextMeshPro
using UnityEngine.SceneManagement;
using TMPro;

public class TimerDisplay : MonoBehaviour
{
    public float timeRemaining = 10f; // Set duration in seconds
    public TextMeshPro timerText; // Use TMP_Text if using TextMeshPro
    public string sceneToLoad = "NextScene";
    public Animator anim;

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            timerText.text = Mathf.Ceil(timeRemaining).ToString(); // Round up for display
        }
        else
        {
            anim.Play("jumpscare");
            StartCoroutine(LoadSceneAfterDelay());
        }
    }

    private System.Collections.IEnumerator LoadSceneAfterDelay()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

