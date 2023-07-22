using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //[SerializeField] private Ship ship;
    [SerializeField] public GameObject applicantPrefab;
    [SerializeField] public GameObject mostRecentApplicant;
  
    // Create the list for successful applicants that are hired
    public List<Applicant> successfulApplicants = new List<Applicant>();

    //This method will be called when the player interacts connected button

    public int currentCrew;
    public Text scoreText;

    void start()
    {
        CheckForParasite();
        //successfulApplicants = applicantPrefab("name").ToList();
        //successfulApplicants.Add(mostRecentApplicant);
    }

    [ContextMenu("Increase Score")]
    public void addCrew()
    {
        currentCrew = currentCrew + 1;
        scoreText.text = currentCrew.ToString();
        Debug.Log("Welcome to the crew!");
    }
   

    public void OnSuccessfulApplicantSelected()
    {
        if (applicantPrefab != null)
        {
            Applicant NewApplicant = new Applicant();
            successfulApplicants.Add(NewApplicant);
            mostRecentApplicant = applicantPrefab;
        }
    }

    private void CheckForParasite()
    {
        for (int selectedApplicant = 0; selectedApplicant < successfulApplicants.Count; selectedApplicant++)
        {
            if (successfulApplicants[selectedApplicant].isParasite == true)
            {
                currentCrew--;
                Debug.Log(" ALARM " + selectedApplicant);
                Debug.Log(" A parasite has been detected onboard: [" + successfulApplicants[selectedApplicant].name + " Crew members under attack!");
            }

            Debug.Log(successfulApplicants.Count);
            Debug.Log(successfulApplicants[0]);

        }
    }

}


//WORKINGS 
//    //declare object to instantiate
//    public GameObject applicant;

//    //successful applicant = accept button pressed

//    public void OnMouseDown()
//    {
//        applicantPrefab.addtoList(successfulApplicants);
//    }
        

////////public void ButtonHit()
////////{
////////    mostRecentApplicant = Instantiate(applicantPrefab);
////////    Instantiate(applicantPrefab);
////////    ship.successfulApplicants.Add(mostRecentApplicant);

////////}

