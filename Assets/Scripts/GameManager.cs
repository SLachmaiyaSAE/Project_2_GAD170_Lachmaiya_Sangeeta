using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Ship ship;
    [SerializeField] private Applicant applicantPrefab;
    [SerializeField] private Applicant mostRecentApplicant;

    // Start is called before the first frame update
    void Start()
    {
        mostRecentApplicant = Instantiate(applicantPrefab);
        //ship.successfulApplicants.Add()
    }

    // Update is called once per frame
    void Update()
    {
        // add to list code
    }
}
