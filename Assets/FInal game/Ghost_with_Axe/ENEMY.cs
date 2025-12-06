using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ENEMY : MonoBehaviour
{
    public GameObject ghost;
    // Start is called before the first frame update
   public float enemyduration = 5;
    float elapsedTime = 0;
    private bool ghoston;
    float appertime;
    public float apperduration = 10;
    public Animator anim;

    void Start()
    {
        //i want to make him apper then dissaper
    }

    // Update is called once per frame
    void Update()
    {
              
        if (appertime >= apperduration) 
        {
            ghost.SetActive(true);
            ghoston = true;
            appertime = 0;
        }


        if (ghoston)
        {
            elapsedTime += Time.deltaTime;
        }
        else 
        {
            appertime += Time.deltaTime;
        }
        
        if (elapsedTime >= enemyduration)
        {//you are supposed to die
            elapsedTime = 0;
            ghost.SetActive(false); 
            StartCoroutine(LoadSceneAfterDelay());  
        }//ENEMY will come out every 10 secounds and will try to kill you in about 2 secounds 
    }

    public void ghostoff()
    {
        ghoston = false;
        elapsedTime = 0;
        appertime = 0;
        ghost.SetActive(false);
    }

    private System.Collections.IEnumerator LoadSceneAfterDelay()
    {
        anim.Play("jumpscare");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
