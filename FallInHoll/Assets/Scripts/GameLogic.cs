using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    int level, lvl_number;
    [SerializeField]
    private GameObject game_over, win;

    Dictionary<int, int> levels_obstacles = new Dictionary<int, int>()
    {
        {1, 7},
        {2, 8},
        {3, 8},
        {4, 11},
        {5, 9},
        {6, 6},
        {7, 8},
        {8, 28},
        {9, 20},
        {10, 5},
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
        if (other.tag == "enemy")
        {
            game_over.SetActive(true);
            Debug.Log("Game Over");
        }
        else
        {
            foreach (var item in other.transform.GetComponents<BoxCollider>())
            {
                item.enabled = false;
            } 
            level -= 1;
            Debug.Log(level);
        }

        if (level == 0)
        {
            PlayerPrefs.SetInt("lvl", lvl_number + 1);
            win.SetActive(true);
            Debug.Log("Win");
            if (lvl_number > PlayerPrefs.GetInt("lvl_record"))
            {
                PlayerPrefs.SetInt("lvl_record", lvl_number + 1);
            }
        }
    }
}
