using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ProgressManager : MonoBehaviour
{
    [SerializeField]
    GameObject progressBar;
    [SerializeField]
    GameObject Blinder;
    // Start is called before the first frame update
    void Start()
    {
        Blinder = GameObject.Find("Blinder");
        progressBar.GetComponent<Image>().enabled = false;
        progressBar.transform.GetChild(0).gameObject.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
