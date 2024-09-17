using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRoller : MonoBehaviour
{
    public void RollDice()
    {
        int diceResult = Random.Range(1, 20);
        Debug.Log($"El dado ha salido: {diceResult}");
    }
}
