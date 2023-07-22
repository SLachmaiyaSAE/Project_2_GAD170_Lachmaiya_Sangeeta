using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Ship ship;
    [SerializeField] public GameObject applicantPrefab;
    [SerializeField] public GameObject mostRecentApplicant;

    public List<Applicant> successfulApplicants = new List<Applicant>();


    public void ButtonHit()
    {
        //mostRecentApplicant = Instantiate(applicantPrefab);
        Instantiate(applicantPrefab);
        //ship.successfulApplicants.Add(mostRecentApplicant);
        
    }

}
