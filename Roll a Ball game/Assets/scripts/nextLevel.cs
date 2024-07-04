using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
 
public class nextLevel : MonoBehaviour
{
    public GameObject player;
    public int sceneBuildIndex;


    private void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "Player") {
            if(player.GetComponent<PlayerController>().count >= 12)
            {
            print("Switching Scene to " + sceneBuildIndex);
            SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
            }
        }
    }
}
