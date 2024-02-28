using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warningcanvas : MonoBehaviour
{
    [SerializeField] private GameObject WarninggO;

    private void Start()
    {
        WarninggO.SetActive(false);
    }
}
