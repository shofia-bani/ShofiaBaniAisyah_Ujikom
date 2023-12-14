using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class munculEnemy : MonoBehaviour
{
    public GameObject enemy;
    public float waktuMinimal, waktuMaximal;
    public float posisiMinimal, posisiMaximal;

// Start is called before the first frame update
    void Start()
    {
     StartCoroutine(munculEnemy());   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator munculEnemy()
    {
        Instantiate(enemy, transform.position + Vector3.right * Random .Range(posisiMinimal,posisiMaximal)
        , Quaternion.identity);
        yield return new WaitForSeconds(Random.Range(waktuMinimal,waktuMaximal));
        StartCoroutine(munculEnemy());

    }
}
