using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtObj : MonoBehaviour
{
    private GameObject hole;
    [SerializeField]
    private Animator anim;

    public void Start()
    {
        hole = GameObject.Find("HoleParent");
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, hole.transform.position) < 2 + hole.transform.localScale.x)
        {
            transform.LookAt(new Vector3(hole.transform.position.x, transform.position.y, hole.transform.position.z));
            anim.Play("builder");
        }
        else
        {
            anim.Play("New State");
        }
    }
}
