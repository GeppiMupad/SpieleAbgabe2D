using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InvestigationfileWeapon : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI WeaponText;

    public static int weaponIndex = 0;

    private string[] weaponA = new string[]
{
        "Natürlcher Tot",
        "Krankheit",
        "Erstochen",
        "Vergiftet",
        "Erschossen"

};

    private void FixedUpdate()
    {
        WeaponText.text = weaponA[weaponIndex]; // shows weapon

        
    }
}
