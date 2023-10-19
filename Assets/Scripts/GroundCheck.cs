using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D Col)
    {
        if(Col.gameObject.tag == "Candy1")
        {
            Destroy(Col.gameObject);
        }
        if(Col.gameObject.tag == "Candy2")
        {
            Destroy(Col.gameObject);
        }
        if(Col.gameObject.tag == "Candy3")
        {
            Destroy(Col.gameObject);
        }
        if(Col.gameObject.tag == "Candy4")
        {
            Destroy(Col.gameObject);
        }
        if(Col.gameObject.tag == "Candy5")
        {
            Destroy(Col.gameObject);
        }
        if(Col.gameObject.tag == "Candy6")
        {
            Destroy(Col.gameObject);
        }




    }   

}
