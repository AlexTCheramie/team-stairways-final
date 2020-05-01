using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Website: https://www.youtube.com/watch?v=2WnAOV7nHW0
/// </summary>

//this is a simple class, so no monobehavior elements
public class InventoryHelp {    
    private List<Weapons> weapons;

    public InventoryHelp() {
        weapons = new List<Weapons>();

        AddWeapon(new Weapons { equipedWeapon = Weapons.WeaponType.Gun});
    }

    public void AddWeapon(Weapons _weapon) {
        weapons.Add(_weapon);
    }
}
