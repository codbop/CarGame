using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parkur_degisme : MonoBehaviour
{
    public GameObject parkur1;
    public GameObject parkur2;
    public GameObject parkur3;
    public GameObject parkur4;
    public GameObject parkur5;
    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        parkur1.SetActive(false);
        parkur2.SetActive(false);
        parkur3.SetActive(false);
        parkur4.SetActive(false);
        parkur5.SetActive(false);
        panel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void parkur1_button() {
        parkur1.SetActive(true);
        parkur2.SetActive(false);
        parkur3.SetActive(false);
        parkur4.SetActive(false);
        parkur5.SetActive(false);
        panel.SetActive(false);
    }

    public void parkur2_button() {
        parkur1.SetActive(false);
        parkur2.SetActive(true);
        parkur3.SetActive(false);
        parkur4.SetActive(false);
        parkur5.SetActive(false);
        panel.SetActive(false);
    }

    public void parkur3_button() {
        parkur1.SetActive(false);
        parkur2.SetActive(false);
        parkur3.SetActive(true);
        parkur4.SetActive(false);
        parkur5.SetActive(false);
        panel.SetActive(false);
    }

    public void parkur4_button() {
        parkur1.SetActive(false);
        parkur2.SetActive(false);
        parkur3.SetActive(false);
        parkur4.SetActive(true);
        parkur5.SetActive(false);
        panel.SetActive(false);
    }

    public void parkur5_button() {
        parkur1.SetActive(false);
        parkur2.SetActive(false);
        parkur3.SetActive(false);
        parkur4.SetActive(false);
        parkur5.SetActive(true);
        panel.SetActive(false);
    }

}
