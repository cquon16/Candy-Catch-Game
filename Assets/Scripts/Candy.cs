using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candy : MonoBehaviour
{

    [SerializeField] GameObject[] candyprefab;
    [SerializeField] float min;
    [SerializeField] float max;
    public int i;

 
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CandySpawn());
    }

    IEnumerator CandySpawn()
    {
        for(i = 0; i<15; i++)
        {
            var wanted = Random.Range(min,max);
            var position = new Vector3(wanted,4);
            GameObject gameObject = Instantiate(candyprefab[Random.Range(0, candyprefab.Length)],position, Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(1, 4));
            Destroy(gameObject, 5f);
        }
    }

}
