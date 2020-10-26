using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene1Behavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameManager gameManager = new GameManager();
        gameManager.ReturnValue();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
