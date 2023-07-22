//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class SpawnPrefabOnClick : MonoBehaviour
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
//            float x = Random.Range(-8f, 8f);
//            float y = Random.Range(-4f, 4f);
//            Instantiate(applicantPrefab, new Vector3(x, y, 0f), Quaternion.identity);
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




