using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    int level, lvl_number;
    [SerializeField]
    private GameObject game_over, win;

    public int points = 0;
    public OnChangePosition HoleScript;
    public bool change_scale = false;

    string name_obj = "";

    bool go = true;

    Dictionary<int, int> levels_obstacles = new Dictionary<int, int>()
    {
        {1, 7},
        {2, 8},
        {3, 8},
        {4, 11},
        {5, 9},
        {6, 6},
        {7, 8},
        {8, 29},
        {9, 20},
        {10, 5},
        {11, 6},
        {12, 12},
        {13, 14},
        {14, 5},
        {15, 9},
        {16, 13},
        {17, 10},
        {18, 7},
        {19, 14},
        {20, 2},
        {21, 6},
        {22, 7},
        {23, 10},
        {24, 12},
        {25, 10},
        {26, 10},
        {27, 10},
        {28, 4},
        {29, 9},
        {30, 6},
    };

    private void Start()
    {
        lvl_number = PlayerPrefs.GetInt("lvl");
        level = levels_obstacles[lvl_number];
        game_over.SetActive(false);
        win.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "enemy" && go)
        {
            game_over.SetActive(true);
            Debug.Log("Game Over");
        }
        else
        {
            /*foreach (var item in other.transform.GetComponents<BoxCollider>())
            {
                item.enabled = false;
            } */
            if (other.transform.parent.gameObject.name != name_obj)
            {
                level -= 1;
                Debug.Log(level);
                name_obj = other.transform.parent.gameObject.name;
                Debug.Log(other.name);
                if (change_scale)
                    CalculateProgress();
            }
        }

        if (level == 0)
        {
            PlayerPrefs.SetInt("lvl", lvl_number + 1);
            win.SetActive(true);
            go = false;
            Debug.Log("Win");
            if ((lvl_number + 1) > PlayerPrefs.GetInt("lvl_record"))
            {
                PlayerPrefs.SetInt("lvl_record", lvl_number + 1);
            }
        }

        
    }

    private void CalculateProgress()
    {
        points++;
        StartCoroutine(HoleScript.ScaleHole());
    }
}
