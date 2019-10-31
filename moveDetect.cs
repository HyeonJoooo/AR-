using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moveDetect : MonoBehaviour
{
    ButtonManager bm;
    // Start is called before the first frame update
    void Start()
    {
        //bm.GetComponent
    }

    // Update is called once per frame
    void Update()
    {
        
        Debug.Log("bm.modecount: "+bm.modeCount);
    }
}
