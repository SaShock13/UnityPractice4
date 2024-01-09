using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CalcScript : MonoBehaviour
{
    [SerializeField]
    TMP_InputField firstNum;
    [SerializeField]
    //InputField secondNum;
    TMP_InputField secondNum;
    [SerializeField]    
    TMP_Text resultText;    
    int first;
    int second;

    // Start is called before the first frame update
    void Start()
    {
        resultText.text = "Результат неизвестен";
        
    }

   public void Add()
    {
        if (CheckNumbers())
        {   
            resultText.text = (first+second).ToString(); 
        }else Error();
    }
    public void Substruct()
    {
        if (CheckNumbers())
        {
            resultText.text = (first - second).ToString();
        }
        else Error();
    }
    public void Multiply()
    {
        if (CheckNumbers())
        {
            resultText.text = (first * second).ToString();
        }
        else Error();
    }
    public void Division()
    {
        if (CheckNumbers())
        {
            if (second != 0)
            {
                resultText.text = ((double)first / (double)second).ToString();
            }
            else Error( "Делить на ноль нельзя!");
        }
        else Error();
    }
    private bool CheckNumbers()
    {
        if (int.TryParse(firstNum.text, out first) & int.TryParse(secondNum.text, out second))
        {
            return true;
        }
        else return false;
    }
    private void Error()
    {
        resultText.text = "Введите корректные числа";
    }
    private void Error(string message)
    {
        resultText.text = message;
    }


}
