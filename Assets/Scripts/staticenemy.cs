using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class staticenemy : MonoBehaviour
{
    public GameObject fhj�rta1, fhj�rta2, fhj�rta3;
    public static int h�lsa;
    
    
    // Start is called before the first frame update
    void Start()
    {
        h�lsa = 3;
        fhj�rta1.gameObject.SetActive(true);
        fhj�rta2.gameObject.SetActive(true);
        fhj�rta3.gameObject.SetActive(true);
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {

            h�lsa -=1;
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (h�lsa > 3)
         h�lsa = 3; 

        switch (h�lsa)
        {

            case 3:
                fhj�rta1.gameObject.SetActive(true);
                fhj�rta2.gameObject.SetActive(true);
                fhj�rta3.gameObject.SetActive(true);
                
                break;

            case 2:
                fhj�rta1.gameObject.SetActive(true);
                fhj�rta2.gameObject.SetActive(true);
                fhj�rta3.gameObject.SetActive(false);
                
                break;

            case 1:
                fhj�rta1.gameObject.SetActive(true);
                fhj�rta2.gameObject.SetActive(false);
                fhj�rta3.gameObject.SetActive(false);
                break;

            case 0:
                fhj�rta1.gameObject.SetActive(false);
                fhj�rta2.gameObject.SetActive(false);
                fhj�rta3.gameObject.SetActive(false);
                SceneManager.LoadScene("Gameover");
                ScoreTextScript.coinAmount = 0;


                break;

                
     
        }




    }

}