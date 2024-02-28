using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonWeapon : MonoBehaviour
{
    public void RightButton()
    {
        // change weapon index
        if (InvestigationfileWeapon.weaponIndex < 4)
            InvestigationfileWeapon.weaponIndex++;
        else
            InvestigationfileWeapon.weaponIndex = 0;
    }

    public void LeftButton()
    {
        // change weapon index
        if (InvestigationfileWeapon.weaponIndex > 0)
            InvestigationfileWeapon.weaponIndex--;
        else
            InvestigationfileWeapon.weaponIndex = 4;
    }
}
