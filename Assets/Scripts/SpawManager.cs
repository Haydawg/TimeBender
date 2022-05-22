using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawManager : MonoBehaviour
{
    [SerializeField]
    Transform spawnLocation;
    PlayerController player;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerController>();
        player.transform.position = spawnLocation.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
