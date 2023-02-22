using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] obst_1, obst_2, obst_3;
    [SerializeField]
    private GameObject ground;
    [SerializeField]
    private Material blue, green, purple;
    void Start()
    {
        for (int i = 0; i < 12; i++)
        {
            if (PlayerPrefs.GetInt("lvl") <= 10)
            {
                ground.GetComponent<MeshRenderer>().material = blue;
                int num = Random.Range(0, obst_1.Length);
                var obj = Instantiate(obst_1[num], obst_1[num].transform.position, obst_1[num].transform.rotation);
                obj.transform.position = new Vector3(Random.Range(-8.0f, 8.0f), obj.transform.position.y, Random.Range(6.0f, -5.0f));
                obj.transform.rotation = Quaternion.AngleAxis(Random.Range(0.0f, 360.0f), Vector3.up);
            }
            else if (10 < PlayerPrefs.GetInt("lvl") && PlayerPrefs.GetInt("lvl") <= 20)
            {
                ground.GetComponent<MeshRenderer>().material = green;
                int num = Random.Range(0, obst_3.Length);
                var obj = Instantiate(obst_3[num], obst_3[num].transform.position, obst_3[num].transform.rotation);
                obj.transform.position = new Vector3(Random.Range(-8.0f, 8.0f), obj.transform.position.y, Random.Range(6.0f, -5.0f));
                obj.transform.rotation = Quaternion.AngleAxis(Random.Range(0.0f, 360.0f), Vector3.up);
            }
            else if (20 < PlayerPrefs.GetInt("lvl"))
            {
                ground.GetComponent<MeshRenderer>().material = purple;
                int num = Random.Range(0, obst_2.Length);
                var obj = Instantiate(obst_2[num], obst_2[num].transform.position, obst_2[num].transform.rotation);
                obj.transform.position = new Vector3(Random.Range(-8.0f, 8.0f), obj.transform.position.y, Random.Range(6.0f, -5.0f));
                obj.transform.rotation = Quaternion.AngleAxis(Random.Range(0.0f, 360.0f), Vector3.up);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
