using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class araba_degisme : MonoBehaviour
{
    public GameObject araba1;
    public GameObject araba2;
    public GameObject araba3;
    public GameObject araba4;
    public GameObject araba5;
    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        araba1.SetActive(false);
        araba2.SetActive(false);
        araba3.SetActive(false);
        araba4.SetActive(false);
        araba5.SetActive(false);
        panel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void araba1_button() {
        araba1.SetActive(true);
        araba2.SetActive(false);
        araba3.SetActive(false);
        araba4.SetActive(false);
        araba5.SetActive(false);
        panel.SetActive(false);
    }

    public void araba2_button() {
        araba1.SetActive(false);
        araba2.SetActive(true);
        araba3.SetActive(false);
        araba4.SetActive(false);
        araba5.SetActive(false);
        panel.SetActive(false);
    }

    public void araba3_button() {
        araba1.SetActive(false);
        araba2.SetActive(false);
        araba3.SetActive(true);
        araba4.SetActive(false);
        araba5.SetActive(false);
        panel.SetActive(false);
    }

    public void araba4_button() {
        araba1.SetActive(false);
        araba2.SetActive(false);
        araba3.SetActive(false);
        araba4.SetActive(true);
        araba5.SetActive(false);
        panel.SetActive(false);
    }

    public void araba5_button() {
        araba1.SetActive(false);
        araba2.SetActive(false);
        araba3.SetActive(false);
        araba4.SetActive(false);
        araba5.SetActive(true);
        panel.SetActive(false);
    }

}
