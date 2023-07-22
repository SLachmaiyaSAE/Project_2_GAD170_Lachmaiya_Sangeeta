using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public List<Applicant> successfulApplicants = new List<Applicant>();
    public Applicant prefab;
    private Applicant applicant;
    //public GameObject crew;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void AddGameObjectToList()
    {
        Applicant instantiatedObject = Instantiate(prefab);
        successfulApplicants.Add(applicant);
    }



}
