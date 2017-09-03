using UnityEngine;
using System.Collections;

public class pipeRepeatScript : MonoBehaviour
{

    public GameObject pipes;
    
    void Start()
    {
        InvokeRepeating("CreateObstacle", 2f, 1.5f);
    }

    void CreateObstacle()
    {
        
        Instantiate(pipes);
    }

}
