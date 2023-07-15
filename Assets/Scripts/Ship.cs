using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public List<Applicant> successfulApplicants = new List<Applicant>();
    public Applicant prefab;
    private Applicant applicant;

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


            // add to list code


            // youtubed the below but did not fully understand how it worked
            //static void Main(string[] args)
            //{
            //    int[] applicant = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            //    Applicant[1] = applicant[1];
            //    Applicant[2] = applicant[2];
            //    Applicant[3] = applicant[3];
            //    Applicant[4] = applicant[4];
            //    Applicant[5] = applicant[5];
            //    Applicant[6] = applicant[6];
            //    Applicant[7] = applicant[7];
            //    Applicant[8] = applicant[8];
            //    Applicant[9] = applicant[9];
            //    Applicant[10] = applicant[10];
            //    Applicant[11] = applicant[11];

}
