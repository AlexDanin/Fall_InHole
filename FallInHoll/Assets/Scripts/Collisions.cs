using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    public int points = 0;
    public OnChangePosition HoleScript;
    public bool change_scale = false;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.transform.parent.gameObject);
        if (change_scale)
            CalculateProgress();
    }

    private void CalculateProgress()
    {
        points++;
        StartCoroutine(HoleScript.ScaleHole());
    }
}
