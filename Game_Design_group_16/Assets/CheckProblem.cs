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
    public TMP_InputField Level3Problem11;
    public TMP_InputField Level3Problem12;
    public TMP_InputField Level3Problem13;
    public TMP_InputField Level3Problem21;
    public TMP_InputField Level3Problem22;
    public TMP_InputField Level3Problem23;
    public TMP_InputField Level3Problem31;
    public string solution1 = "String carName = Volvo;";
    public string solution2 = "boolean correct = true;";
    public string solution3 = "float pi = 3.14;";
    private string solution4 = "int age = "; 
    public string solution211 = "if";
    public string solution212 = ">"; 
    public string solution222 = "!=";   
    public string solution231 = "=="; 
    public string solution232 = "false"; 
    public string solution311 = "for"; 
    public string solution312 = "Yes"; 
    public string solution313 = "i++"; 
    public string solution322 = "100"; 
    public string solution323 = "i"; 
    public string solution331 = "for(int i = 10; i < 20; i++)"; 
    public Button Proceed1;
    public Button Proceed2;
    public Button Proceed3;

    public AudioSource screenSource;
    public AudioClip unpleasantSound;
    public AudioClip pleasantSound;

    void Start()
    {
        Proceed1.interactable = false;
        Proceed2.interactable = false;
        Proceed3.interactable = false;
    }

    private bool verifyL1Problem4(string str) {
        bool res = false;
        int a;
        if (str.Length>solution4.Length && str.Substring(0,solution4.Length)==solution4) {
            string number = Regex.Match(str.Substring(solution4.Length), @"\d+").Value;
            if (int.TryParse(number, out a) && str.Substring(str.Length-1)==";")
                res = true;
        }

        if (res)
        {
            Level1Problem4.selectionColor = Color.green;
        } else
            Level1Problem4.selectionColor = Color.red;

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

    private bool checkProblem(TMP_InputField field, string solution)
    {
        if (field.text == solution)
        {
            field.selectionColor = Color.green;
            return true;
        }

        field.selectionColor = Color.red;
        return false;
    }

    void Update()
    {
        if (checkProblem(Level1Problem1,solution1) && checkProblem(Level1Problem2, solution2) 
            && checkProblem(Level1Problem3, solution3) && verifyL1Problem4(Level1Problem4.text)) 
        {
            if (Proceed1.interactable == false)
            {
                screenSource.PlayOneShot(pleasantSound);
                Debug.Log("Pleasant Sound plated");
            }
            Proceed1.interactable = true;
        } 
        else
        {
            if (Proceed1.interactable == true)
            {
                screenSource.PlayOneShot(unpleasantSound);
                Debug.Log("Unpleasant Sound plated");
            }
            Proceed1.interactable = false;
        }

        if (Level2Problem11.text == solution211 && Level2Problem12.text == solution212 
        && verifyL2Problem2() &&
        Level2Problem31.text == solution231 && Level2Problem32.text == solution231 
        && Level2Problem33.text == solution232)
        {
            if (Proceed1.interactable == false)
            {
                screenSource.PlayOneShot(pleasantSound);
                Debug.Log("Pleasant Sound plated");
            }
            Proceed2.interactable = true;
        }
        else
        {
            if (Proceed2.interactable == true)
            {
                screenSource.PlayOneShot(unpleasantSound);
            }
            Proceed2.interactable = false;
        }

        if (Level3Problem11.text == solution311 && Level3Problem12.text == solution312 && 
        Level3Problem13.text == solution313 && Level3Problem21.text == solution311 && 
        Level3Problem22.text == solution322 && Level3Problem23.text == solution323 &&
        Level3Problem31.text == solution331)
        {
            if (Proceed1.interactable == false)
            {
                screenSource.PlayOneShot(pleasantSound);
                Debug.Log("Pleasant Sound plated");
            }
            Proceed3.interactable = true;
        }
        else
        {
            if (Proceed3.interactable == true)
            {
                screenSource.PlayOneShot(unpleasantSound);
            }
            Proceed3.interactable = false;
        }
    }
}
