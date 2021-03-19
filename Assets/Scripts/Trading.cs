using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trading : MonoBehaviour
{
    [SerializeField]
    private List<Trader> traders;

    private void Awake()
    {
        TradingCycle();
    }



    private void TradingCycle()
    {
        for (int i = 0; i < traders.Count;)
        {

            Trader left = traders[i];
            i++;
            Trader right = traders[i];

            if (left.Trade() == right.Trade())
            {
                left.Money += 4;
                right.Money += 4;

                Debug.Log(left.name + " traded with " + right.name);
            }

            i++;
        }
    }

}
