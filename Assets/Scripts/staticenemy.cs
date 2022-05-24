using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class staticenemy : MonoBehaviour
{
    public GameObject fhjärta1, fhjärta2, fhjärta3;
    public static int hälsa;
    
    
    // Start is called before the first frame update
    void Start()
    {
        hälsa = 3;
        fhjärta1.gameObject.SetActive(true);
        fhjärta2.gameObject.SetActive(true);
        fhjärta3.gameObject.SetActive(true);
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {

            hälsa -=1;
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (hälsa > 3)
         hälsa = 3; 

        switch (hälsa)
        {

            case 3:
                fhjärta1.gameObject.SetActive(true);
                fhjärta2.gameObject.SetActive(true);
                fhjärta3.gameObject.SetActive(true);
                
                break;

            case 2:
                fhjärta1.gameObject.SetActive(true);
                fhjärta2.gameObject.SetActive(true);
                fhjärta3.gameObject.SetActive(false);
                
                break;

            case 1:
                fhjärta1.gameObject.SetActive(true);
                fhjärta2.gameObject.SetActive(false);
                fhjärta3.gameObject.SetActive(false);
                break;

            case 0:
                fhjärta1.gameObject.SetActive(false);
                fhjärta2.gameObject.SetActive(false);
                fhjärta3.gameObject.SetActive(false);
                SceneManager.LoadScene("Gameover");
                ScoreTextScript.coinAmount = 0;


                break;

                
     
        }




    }

}