﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Food", menuName = "Inventory/Food")]
public class Food : Item
{
    
    public float regenAmout;
    public int ticksToCook;
    private int ticksCooking;
    public Food cookedDrop;

    public void Cook()
    {
        if (ticksToCook == -1)
        {
            return;
        }

        ticksCooking += 1;

        if (ticksCooking == ticksToCook)
        {
            Inventory.instance.Add(cookedDrop);
            Inventory.instance.Remove(this);
        }
    }




}