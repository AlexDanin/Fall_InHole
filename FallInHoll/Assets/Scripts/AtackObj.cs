using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtackObj : MonoBehaviour
{
    private GameObject hole;
    [SerializeField]
    private float speed = 5.0f;
    void Start()
    {
        hole = GameObject.Find("HoleParent");
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(new Vector3(hole.transform.position.x, transform.position.y, hole.transform.position.z));
        transform.position = Vector3.MoveTowards(transform.position, hole.transform.position, speed * Time.deltaTime);
    }
}
