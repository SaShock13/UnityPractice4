using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Comparer : MonoBehaviour
{
    [SerializeField]
    TMP_InputField firstNum;

    [SerializeField]    
    TMP_InputField secondNum;

    [SerializeField]
    TMP_Text resultText;
    
    int first;
    int second;

    public void CompareNums()
    {
        if (int.TryParse(firstNum.text, out first) & int.TryParse(secondNum.text, out second))
        {
            if (first != second)
            {
               
                    resultText.text = $"Наибольшее число {((first>second)?first:second)}";
               
            }
            else resultText.text = "Числа равны";
        }
        else resultText.text = "Введите корректные данные";
    }
}
