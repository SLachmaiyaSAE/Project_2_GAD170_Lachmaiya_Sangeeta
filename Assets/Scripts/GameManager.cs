using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Ship ship;
    [SerializeField] public Applicant applicantPrefab;
    [SerializeField] public Applicant mostRecentApplicant;

    public GameObject crew;

   
    public List<Applicant> successfulApplicants = new List<Applicant>();


    public void ButtonHit()
    {
        //mostRecentApplicant = Instantiate(applicantPrefab);
        Instantiate(crew);
        //ship.successfulApplicants.Add(mostRecentApplicant);
        
    }

}
