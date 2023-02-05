using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] obst_1;
    void Start()
    {
        for (int i = 0; i < 12; i++)
        {
            int num = Random.Range(0, obst_1.Length);
            var obj = Instantiate(obst_1[num], obst_1[num].transform.position, obst_1[num].transform.rotation);
            obj.transform.position = new Vector3(Random.Range(-8.0f, 8.0f), obj.transform.position.y, Random.Range(6.0f, -5.0f));
            obj.transform.rotation = Quaternion.AngleAxis(Random.Range(0.0f, 360.0f), Vector3.up);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
