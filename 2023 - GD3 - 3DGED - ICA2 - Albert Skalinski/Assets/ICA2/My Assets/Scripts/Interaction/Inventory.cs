using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public bool hasKey = false;
    public bool hasMace = false;

    public void ObtainKey()
    {
        hasKey = true;
    }

    public void ObtainMace()
    {
        hasMace = true;
    }
}