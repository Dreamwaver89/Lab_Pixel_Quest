using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameconroller : MonoBehaviour
{
    public GameObject door1;
    public GameObject door2;
    public GameObject painting;

    public GameObject ghost1;

    public AudioSource doorOneSfx; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (door1.activeSelf && ghost1.activeSelf)
        {
            ghost1.transform.root.GetComponent<ENEMY>().ghostoff();
            doorOneSfx.Play();
        }
        if (door2.activeSelf && ghost1.activeSelf)
        {
            ghost1.transform.root.GetComponent<ENEMY>().ghostoff();
        }
        if (painting.activeSelf && ghost1.activeSelf)
        {
            ghost1.transform.root.GetComponent<ENEMY>().ghostoff();
        }
    }
}
