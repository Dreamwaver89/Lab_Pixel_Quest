using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENEMY : MonoBehaviour
{
    public GameObject ghost;
    // Start is called before the first frame update
    float enemyduration = 5;
    float elapsedTime = 0;
    private bool ghoston;
   
        void Start()
    {
        //i want to make him apper then dissaper
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
          ghost.SetActive(true);
        }
        elapsedTime += Time.deltaTime;

        if (elapsedTime >= enemyduration)
        {//you are supposed to die
            elapsedTime = 0;
            ghost.SetActive(false); 
        }//ENEMY will come out every 10 secounds and will try to kill you in about 2 secounds 
    }
}
