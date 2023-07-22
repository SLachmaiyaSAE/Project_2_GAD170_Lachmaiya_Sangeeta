using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabManager : MonoBehaviour
{
    public GameObject prefabToSpawn; // Drag and drop the prefab to spawn in the Inspector
    public Transform spawnPosition; // The position where the prefab should be spawned

    public GameObject applicantPrefab;



    void Update()
    { 
    
    }

        private void OnMouseDown()
        {
            Instantiate(applicantPrefab, spawnPosition.position, Quaternion.identity);
        }
}
    





    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        Instantiate(applicantPrefab, transform.position, Quaternion.identity);
    //    }

    //public List<Applicant> successfulApplicants = new List<Applicant>();

    //public void SpawnPrefab()
    //{
    //    if (prefabToSpawn == null)
    //    {
    //        Debug.LogError("PrefabToSpawn is not assigned! Please drag and drop the prefab in the Inspector.");
    //        return;
    //    }

    //    GameObject applicantPrefab = Instantiate(prefabToSpawn, spawnPosition.position, Quaternion.identity);

    //    // You can add some logic here to display the spawnedPrefab for the player to accept or reject.
    //}

    //public void AcceptPrefab(GameObject prefab)
    //{
    //    successfulApplicants.Add(pre);   
    //    // You can add some logic here to handle the accepted prefab, e.g., give rewards or do something with it.
    //}

    //public void RejectPrefab(GameObject prefab)
    //{
    //    Destroy(prefab);
    //    // You can add some logic here to handle the rejected prefab, e.g., punish the player or remove it from the game.
    //}

    //public List<GameObject> GetAcceptedPrefabs()
    //{
    //    return new List<Applicant>();
    //}

//{
//    public GameObject applicantPrefab; // Drag and drop the prefab you want to spawn in the Inspector.
//    public bool randomSpawn = false; // Set this to true if you want to spawn the prefab at random positions.

//    private void OnMouseDown()
//    {
//        SpawnPrefab();
//    }

//    private void SpawnPrefab()
//    {
//        if (applicantPrefab == null)
//        {
//            Debug.LogError("PrefabToSpawn is not assigned! Please drag and drop the prefab in the Inspector.");
//            return;
//        }

//        if (randomSpawn)
//        {
//            float x = Random.Range(-7.6963f, 7.6963f);
//            float y = Random.Range(-1.5095f, 1.5095f);
//            Instantiate(applicantPrefab, new Vector3(x, y, 0f), Quaternion.identity);
//            Debug.Log("Applicant spawned");
//        }
//        else
//        {
//            Instantiate(applicantPrefab, transform.position, Quaternion.identity);
//        }
//    }
//}


        //[SerializeField] private GameObject prefab;
        //[SerializeField] private Vector3 spawnPosition;
        //[SerializeField] private bool random;


        //public void OnSpawnPrefab()
        //{
        //    if(random)
        //    {
        //        float x = Random.Range(-8, 8);
        //        float y = Random.Range(-4, 4);
        //        Instantiate(prefab, new Vector3(x,y), Quaternion.identity);
        //    }
        //    else
        //    {
        //        Instantiate(prefab, spawnPosition, Quaternion.identity);
        //    }
        //}




