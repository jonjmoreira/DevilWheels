using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalcadaEstradas : MonoBehaviour
{
    public GameObject motorEstrada;
    public MotorEstradas motorEstradasScript;
    public GameObject carroPrincipal;

    void Start()
    {
        motorEstrada = GameObject.Find("MotorEstradas");
        motorEstradasScript = motorEstrada.GetComponent<MotorEstradas>();
    }

    void OnTriggerEnter2D(Collider2D cInfo)
    {
        if(cInfo.gameObject.tag == "Carro")
        {
            motorEstradasScript.SpeedCalcada();
            carroPrincipal.GetComponent<AudioSource>().pitch = 1f;
        }
    }

    void OnTriggerExit2D(Collider2D cInfo)
    {
        if (cInfo.gameObject.tag == "Carro")
        {
            motorEstradasScript.SpeedEstrada();
            carroPrincipal.GetComponent<AudioSource>().pitch = 1.6f;
        }
    }
}
