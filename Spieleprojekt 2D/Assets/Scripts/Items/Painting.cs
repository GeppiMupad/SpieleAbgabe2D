using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class Painting : MonoBehaviour
{

    [SerializeField] private GameObject BackgO;

    

    private float zPos = 0f;

    private int index = 0;
    private bool canSwitch = true;


    /// <summary>
    /// Rotate Painting through Arrows, Left Right Arrow Rotates Z, and Up Arrow Opens or Closes Back Side of Painting
    /// </summary>
    void Update()
    {
        if (Item.isActive == true)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow) && canSwitch == true && index == 0 )
            {
                  index = 1;
                  canSwitch = false;
                  BackgO.SetActive(true);                                           
            }
            if (Input.GetKeyDown(KeyCode.UpArrow) && canSwitch == true && index == 1)
            {
                index = 0;
                BackgO.SetActive(false);
            }
            canSwitch = true;

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.Rotate(0f, 0f, zPos - 90f, Space.Self);
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.Rotate(0f, 0f, zPos + 90f, Space.Self);
            }
        }
    }
}
