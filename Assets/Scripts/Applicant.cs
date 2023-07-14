using System.Collections;
using System.Collections.Generic;
using UnityEditor.TextCore.Text;
using UnityEngine;

public class Applicant : MonoBehaviour
{
    [SerializeField] private string hobby;
    [SerializeField] public string crewMateName;
    [SerializeField] private bool isParasite;

    private System.Random rnd = new System.Random();

    // Human hobbies
    private string[] humanHobbies = {"Basketball", "Coffee with mates", "Going to the beach", "Horror movies", "Gardening"};

    // Parasite hobbies
    private string[] parasiteHobbies = {"Eating Cats", "Justin Bieber", "Smelling lungs", "Skinning lamas" };

    // Human names
    private string[] names = {"Malini", "Mani", "Kavita", "Sangeeta", "Mavesh", "Malaria", "Tape", "Flea", "Tick" };


    // Update is called once per frame
    void Start()
    {
        GenerateInfo();
    }

    public void GenerateInfo()
    {
        GenerateName();
        GenerateIsParasite();
        if (isParasite == true)
        {
            GenerateisParasiteHobby();
        }
        else
        {
            GenerateHumanHobby();
        }
    }

    private void GenerateName()
    {
        crewMateName = names[rnd.Next(0, 9)];
        Debug.Log(crewMateName);
    }
    private void GenerateHumanHobby()
    {
        hobby = humanHobbies[rnd.Next(0, 5)];
        Debug.Log(hobby);
    }

    private void GenerateisParasiteHobby()
    {
        hobby = parasiteHobbies[rnd.Next(0, 4)];
        Debug.Log(hobby);
    }
    private void GenerateIsParasite()
    {
        isParasite = Random.value < 0.25f;
    }


    // youtubed the below but did not fully understand how it worked
    //static void Main(string[] args)
    //{
    //    int[] applicant = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11};
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
    //    Applicant[11] = Applicant[11];

    //    for (int i = 0;.....

    //Generate a name (use random), make a function for this
    //Generate if its an alien, 
    //Generate a hobby (same thing)


   







}
