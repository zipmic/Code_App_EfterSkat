using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AppController : MonoBehaviour {


	public Text ProcentText, LeftText, RightText, UdbetaltText;
	public InputField MoneyField;


	private float procent = 38f;

    private float currentMoneyInput;

    private float lon, ambidrag, skat, finalmoney;


	// Use this for initialization
	void Start ()
	{
		

	}

    public void InputValueChange()
    {
        currentMoneyInput = float.Parse(MoneyField.text);

        lon = currentMoneyInput;

        ambidrag = 0.08f * lon;

        skat = (procent/100) * (lon - ambidrag);

        finalmoney = lon - ambidrag - skat;

        //LeftText = "Løn:\nAM-bidrag:\nA-skat:";
        RightText.text = lon.ToString() + " DKK" + "\n" + ambidrag.ToString() + " DKK" + "\n" + skat.ToString() + " DKK" + "\n";
        UdbetaltText.text = "Udbetalt efter skat:\n"+finalmoney + " DKK";

    }



    public void PlusProcent()
    {
        if(procent < 100)
        {
            procent++;
            ProcentText.text = procent + "%";
        }
    }

    public void MinusProcent()
    {
        if (procent > 0)
        {
            procent--;
            ProcentText.text = procent + "%";
        }
    }




}
