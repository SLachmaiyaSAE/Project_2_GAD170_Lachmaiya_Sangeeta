using System.Collections;
using System.Collections.Generic;
using UnityEditor.TextCore.Text;
using UnityEngine;
using TMPro;

// Applicant class
public class Applicant : MonoBehaviour
{
    // string used because it represents a sequence of characters
    [SerializeField] private string hobby;
    [SerializeField] public string crewMateName;
    // bool used because represnts true or false values
    [SerializeField] public bool isParasite;
    // TextMexhProUGUI used as that what it uses in the system - this populates as simple text
    [SerializeField] private TextMeshProUGUI messageLabel;
    // this variable updates the text that underneather the mssage label - this is connected to the button
    [SerializeField] private UITextUpdater uiTextUpdater;

    private System.Random rnd = new System.Random();

    // Human hobbies
    private string[] humanHobbies = {"quidditch", "coffee with mates", "horror movies", "painting", "hiking", "dancing", "stand up comedy"};

    // Parasite hobbies
    private string[] parasiteHobbies = {"eating cats", "Justin Bieber", "smelling lungs", "watching Days of Our Lives", "mouth feels", "socks with crocs", "shaving heads"};

    // Human and parasite names
    private string[] names = {"Malini", "Mani", "Kavita", "Sangeeta", "Mavesh", "Malaria", "Tape", "Flea", "Tick" };



    // Update is called once per frame
    void Start()
    {
        //this pulls all the info below into one
        GenerateInfo();
    }

    public void GenerateInfo()
    {
        // name will alwaus be constant, so I have it first here
        GenerateName();

        // system then checks if it is a parasite
        GenerateIsParasite();
        if (isParasite == true)
        {
            // if it is a parasite it will generate a parasite hibby pulled from the above array
            GenerateisParasiteHobby();
        }
        else
        {
            // if it is not a parasite it will generate a human hobby
            GenerateHumanHobby();
        }
        // the below debug organises the information into a sentene that will be populated according to line 59's uitextupdater
        Debug.Log("Hi, I'd like to join your crew. My name is " + crewMateName + ", my hobby is " + hobby + ". ");
        uiTextUpdater.UpdateText("' I'd like to join your crew. My name is " + crewMateName + ", and I enjoy " + hobby + ". '");
    }

    // this method tells tells the system to read from the array specified in line 29
    private void GenerateName()
    {
        crewMateName = names[rnd.Next(0, 9)];
        //Debug.Log(crewMateName);
    }

    // this method tells tells the system to read from the array specified in line 23
    private void GenerateHumanHobby()
    {
        hobby = humanHobbies[rnd.Next(0, 7)];
        //Debug.Log(hobby);
    }

    // this method tells tells the system to read from the array specified in line 26
    private void GenerateisParasiteHobby()
    {
        hobby = parasiteHobbies[rnd.Next(0, 7)];
        //Debug.Log(hobby);
    }
    // this method speaks to line 47, telling it to populate parasites 25% of the time
    private void GenerateIsParasite()
    {
        isParasite = Random.value < 0.25f;
    }



    private void Update()
    {
    
    }


}
