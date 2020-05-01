using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class equipmentDisplay : MonoBehaviour
{
    public Image[] equipment;
    //public Sprite equip1;
    //public Sprite equip2;
    //public Sprite equip3;
    //public Sprite equip4;

    public static int currentEquip;


    //for the inventory
    private Weapons _weapons;

    public void SetWeapons(Weapons weapons) {
        this._weapons = weapons;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 1; i < equipment.Length; i++)
        {
            if (i == (currentEquip))
            {
                equipment[i].enabled = true;
            }
            else
            {
                equipment[i].enabled = false;
            }
        }
    }

    //Call this when the player changes equipment
    public static void ChangeCurrentEquip(int val)
    {
        if ((val <= 4) && (val >= 1))
        {
            currentEquip = val;
        }
    }
}
