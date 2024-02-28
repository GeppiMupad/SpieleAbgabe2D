using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Send : MonoBehaviour
{
    [SerializeField] private GameObject WarninggO;
    public void OnClick()
    {
        AnalyzeResult();
        WarninggO.SetActive(true);
    }

    private void AnalyzeResult()
    {
        if(Investigationfile.prepetratorIndex == 2 &&  InvestigationfileMotive.motiveIndex == 2 && InvestigationfileWeapon.weaponIndex == 3)
        {
            Button.allCorrect = true;
        }
        else
        {
            Button.allCorrect = false;
        }
        

    }
}
