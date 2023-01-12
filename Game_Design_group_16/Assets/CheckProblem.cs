using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class CheckProblem : MonoBehaviour
{
    public TMP_InputField Level1Problem1;
    public TMP_InputField Level1Problem2;
    public TMP_InputField Level1Problem3;
    public TMP_InputField Level1Problem4;
    public TMP_InputField Level2Problem11;
    public TMP_InputField Level2Problem12;
    public TMP_InputField Level2Problem21;
    public TMP_InputField Level2Problem22;
    public TMP_InputField Level2Problem23;
    public TMP_InputField Level2Problem24;
    public TMP_InputField Level2Problem31;
    public TMP_InputField Level2Problem32;
    public TMP_InputField Level2Problem33;
    public string solution1 = "String carName = Volvo;";
    public string solution2 = "boolean correct = true;";
    public string solution3 = "float pi = 3.14;";
    private string solution4 = "int age = "; 
    public string solution211 = "if";
    public string solution212 = ">"; 
    public string solution222 = "!=";   
    public string solution231 = "=="; 
    public string solution232 = "false"; 
    public Button Proceed1;
    public Button Proceed2;

    void Start()
    {
        Proceed1.interactable = false;
        Proceed2.interactable = false;
    }

    private bool verifyL1Problem4(string str) {
        bool res = false;
        int a;
        if (str.Length>solution4.Length && str.Substring(0,solution4.Length)==solution4) {
            string number = Regex.Match(str.Substring(solution4.Length), @"\d+").Value;
            if (int.TryParse(number, out a) && str.Substring(str.Length-1)==";")
                res = true;
        }
        return res;
    }

    private bool verifyL2Problem2() {
        bool res = false;
        int a;
        int b;

        if (Level2Problem23.text == solution211 && Level2Problem24.text == solution222) {
            if (int.TryParse(Level2Problem21.text, out a) && int.TryParse(Level2Problem22.text, out b)) {
                if (a != b) res = true;
            }
        }
        return res;
    }

    void Update()
    {
        if (Level1Problem1.text == solution1 && Level1Problem2.text == solution2 &&
         Level1Problem3.text == solution3 && verifyL1Problem4(Level1Problem4.text)) 
        {
            Proceed1.interactable = true;
        }

        if (Level2Problem11.text == solution211 && Level2Problem12.text == solution212 && verifyL2Problem2() &&
        Level2Problem31.text == solution231 && Level2Problem32.text == solution231 
        && Level2Problem33.text == solution232)
        {
            Proceed2.interactable = true;
        }
    }
}
