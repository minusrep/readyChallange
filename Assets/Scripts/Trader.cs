using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trader : MonoBehaviour
{
    [SerializeField]
    private int type;

    [SerializeField]
    private int money;

    public int Money
    {
        get
        {
            return money;
        }

        set
        {
            if (value > 0)
                 money = value;
        }
    }


    public bool Trade()
    {
        switch (type)
        {
            case 1:
                return true;
            case 2:
                return false;
            default:
                return false;
        }
    }

}
