using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    // Create the list for successful applicants that are hired
    public List<Applicant> successfulApplicants = new List<Applicant>();

    // declaring my game object to instantiate
    public GameObject Applicant;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ClonePrefab();
        }
    }

    void ClonePrefab()
    {
        if(Applicant == null)
        {
            Vector3 spawnPosition = transform.position;
            Quaternion spawnRotation = transform.rotation;
            GameObject clone = Instantiate(Applicant, spawnPosition, spawnRotation);
          
        }
    }








    //private Applicant applicant;


    //// Update is called once per frame
    //public void AddGameObjectToList()
    //{
    //    Applicant instantiatedObject = Instantiate(prefab);
    //    successfulApplicants.Add(applicant);
    //}





}
