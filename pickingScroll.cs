using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickingScroll : MonoBehaviour
{
    Ray m_ray;
    RaycastHit m_rayHit;
    GameObject m_selectObject;
    Vector3 m_orgPos;

    [SerializeField]
    GameObject scrollPanel;
    [SerializeField]
    GameObject scrollbar;

    int count = 0;

    public GameObject GetPickObject()
    {
        m_ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(m_ray, out m_rayHit, 1000f, -1))
        {
            return m_rayHit.collider.gameObject;
        }
        return null;
    }
    // Use this for initialization
    void Start()
    {
        scrollPanel.GetComponent<RawImage>().enabled = false;
        scrollbar.GetComponentsInChildren<Transform>();
        for (int i = 0; i < scrollbar.transform.childCount; ++i)
        {
            scrollbar.transform.GetChild(i).gameObject.SetActive(false);
        }
        //scrollPanel.transform.GetChild(0).gameObject.SetActive(false);
        scrollPanel.transform.GetChild(1).gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            int temp = 0;
            m_selectObject = GetPickObject();
            if (m_selectObject == null)
            {
                scrollPanel.GetComponent<RawImage>().enabled = false;
                for (int i = 0; i < scrollPanel.transform.childCount; ++i)
                {
                    scrollPanel.transform.GetChild(i).gameObject.SetActive(false);
                }
                scrollPanel.transform.GetChild(1).gameObject.SetActive(false);
            }
            Debug.Log("m_selectObject: " + m_selectObject);
            if (m_selectObject.name == "scrollPanel" && count == 0)
            {
                //scrollBar = GameObject.Find("Scrollbar");
                scrollPanel.GetComponent<RawImage>().enabled = true;
                scrollbar.GetComponentsInChildren<Transform>();
                for (int i = 0; i < scrollbar.transform.childCount; ++i)
                {
                    scrollbar.transform.GetChild(i).gameObject.SetActive(true);
                }
                //scrollPanel.transform.GetChild(0).gameObject.SetActive(true);
                scrollPanel.transform.GetChild(1).gameObject.SetActive(true);
                count = 1;
                temp = 1;
            }
            if (m_selectObject.name == "scrollPanel" && count == 1 && temp == 0)
            {
                //scrollBar = GameObject.Find("Scrollbar");
                scrollPanel.GetComponent<RawImage>().enabled = false;
                scrollbar.GetComponentsInChildren<Transform>();
                for (int i = 0; i < scrollbar.transform.childCount; ++i)
                {
                    scrollbar.transform.GetChild(i).gameObject.SetActive(false);
                }
                //scrollPanel.transform.GetChild(0).gameObject.SetActive(false);
                scrollPanel.transform.GetChild(1).gameObject.SetActive(false);
                count = 0;
            }
        }

        if (m_selectObject != null)
        {
            Debug.DrawRay(m_ray.origin, m_ray.direction * m_rayHit.distance, Color.red);
        }
    }
}
