using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    [SerializeField]
    GameObject CirGreen;
    [SerializeField]
    GameObject CirYellow;

    public int modeCount = 0;

    public void PressButton()
    {
        int count = 0;
        if (CirGreen.activeSelf==true && CirYellow.activeSelf==false)
        {
            CirGreen.SetActive(false);
            CirYellow.SetActive(true);
            count++;
            modeCount = 1;
        }
        if (CirGreen.activeSelf == false && CirYellow.activeSelf == true && count == 0)
        {
            CirGreen.SetActive(true);
            CirYellow.SetActive(false);
            modeCount = 2;
        }
    }
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        CirGreen.SetActive(true);
        CirYellow.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
