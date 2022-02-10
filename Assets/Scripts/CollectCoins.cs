using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectCoins : MonoBehaviour
{
    private int counter = 0;
    public Text t;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Coin")
        {
            counter++;
            t.text = "Coins: " + counter;

            print(counter);

            Destroy(other.gameObject);
        }
    }
}
