using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day2 : MonoBehaviour
{
    public int currentGold = 72;
    public bool pureOfHeart = true;
    public bool hasSecretInacantation = false;
    public string rareItem = "Reliktowa Maska";
    public string characterAction = "Atak";
    public int diceRoll = 7;




    /* Dzisiaj wykonam podstawy pętli if while itp, pozniej zajme sie tablicami i listami
    dzisiaj wyjątkowo na nic więcej nie mam czasu
    
    */
    void Start()
    {
        List<string> partyMembers = new List<string>()
        {"Łowca", "Żyd", "Facet"};
        partyMembers.Add("Marian");
        partyMembers.Insert(1, "szaman");
        partyMembers.Remove("Łowca");
        Debug.LogFormat("Uczestników: {0}", partyMembers.Count);


        switch (diceRoll)
        {
            case 7:
            case 15:
            Debug.Log("cos tam zadales ale tak srednio bym powiedział");
            break;
            case 20:
            Debug.Log("O PANIE JAKI POCISK OYOYYOOYOYOY");
            break;
            default:
            Debug.Log("Pudło Padawanie");
            break;
        }





        switch (characterAction)
        {
            case "Regeneracja":
            Debug.Log("Pora się zregenerować");
            break;
            case "Atak":
            Debug.Log("Do Broni");
            break;
            default:
            Debug.Log("Bronimy się panowie");
            break;
        }








        OpenTreasureChamber();



        if (currentGold > 50) {
            Debug.Log("jesteś bogaty tak trzymaj");


        }
        else if(currentGold < 15){
            Debug.Log("posiadasz tak mało złota że nikt ci niczego nie podpierdoli");

        }
        else{
            Debug.Log("no ani tak na bogato ani na biednego żyć nie umierać");

        }
        
    }
    public void OpenTreasureChamber()
    {
        if (pureOfHeart && rareItem == "Reliktowa Maska")
        {
            if(!hasSecretInacantation)
            {
                Debug.Log("Masz ducha, ale nie masz wiedzy");
            }
            else{
                Debug.Log("No i ez wygrałeś masz ten zastrany skarb");

            }

        }
        else
        {
            Debug.Log("Zapraszamy jak będziesz posiadać potrzebne przedmioty");
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
