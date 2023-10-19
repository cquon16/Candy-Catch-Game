using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyCollect : MonoBehaviour
{

   public int points;

   public void OnTriggerEnter2D(Collider2D Col)
    {
        if(Col.gameObject.tag == "Candy1")
        {
            Debug.Log("Candy Collected!");
            points = points + 10;
            Debug.Log("Points:" + points);
            //Col.gameObject.SetActive(false);
            Destroy(Col.gameObject);
        }

        if(Col.gameObject.tag == "Candy2")
        {
            Debug.Log("Candy Collected!");
            points = points + 3;
            Debug.Log("Points:" + points);
            //Col.gameObject.SetActive(false);
            Destroy(Col.gameObject);
        }

        if(Col.gameObject.tag == "Candy3")
        {
            Debug.Log("Candy Collected!");
            points = points + 1;
            Debug.Log("Points:" + points);
            //Col.gameObject.SetActive(false);
            Destroy(Col.gameObject);
        }

        if(Col.gameObject.tag == "Candy4")
        {
            Debug.Log("Candy Collected!");
            points = points + 6;
            Debug.Log("Points:" + points);
            //Col.gameObject.SetActive(false);
            Destroy(Col.gameObject);
        }

        if(Col.gameObject.tag == "Candy5")
        {
            Debug.Log("Candy Collected!");
            points = points + 8;
            Debug.Log("Points:" + points);
            //Col.gameObject.SetActive(false);
            Destroy(Col.gameObject);
        }

        if(Col.gameObject.tag == "Candy6")
        {
            Debug.Log("Candy Collected!");
            points = points + 2;
            Debug.Log("Points:" + points);
            //Col.gameObject.SetActive(false);
            Destroy(Col.gameObject);
        }

    }
}
