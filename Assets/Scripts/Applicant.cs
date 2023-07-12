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

    //Generate a name (use random), make a function for this
    //Generate if its an alien, 
    //Generate a hobby (same thing)

}
