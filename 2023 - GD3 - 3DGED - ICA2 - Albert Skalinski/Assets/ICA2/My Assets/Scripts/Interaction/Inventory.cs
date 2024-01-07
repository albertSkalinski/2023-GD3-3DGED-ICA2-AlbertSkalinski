using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public bool hasKey = false;
    public bool hasMace = false;

    //Functions for obtaining items
    public void ObtainKey()
    {
        hasKey = true;
    }

    public void ObtainMace()
    {
        hasMace = true;
    }
}