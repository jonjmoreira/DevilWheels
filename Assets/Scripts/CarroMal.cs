using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarroMal : MonoBehaviour
{
    public GameObject motorEstrada;
    public MotorEstradas motorEstradasScript;
    public GameObject carroPrincipal;
    public GameObject VidasGO;
    public Vidas vidasScript;

    void Start()
    {
        motorEstrada = GameObject.Find("MotorEstradas");
        motorEstradasScript = motorEstrada.GetComponent<MotorEstradas>();

        VidasGO = GameObject.Find("Vidas");
        vidasScript = VidasGO.GetComponent<Vidas>();
    }

    void OnCollisionEnter2D(Collision2D cInfo)
    {
        if(cInfo.gameObject.tag == "Carro")
        {
            motorEstradasScript.SpeedCarroMal();
            carroPrincipal.GetComponent<AudioSource>().pitch = 1f;

            vidasScript.contadorVidas -=1;
            vidasScript.ImagemMenosVida();
        }
    }

    void OnCollisionExit2D(Collision2D cInfo)
    {
        if (cInfo.gameObject.tag == "Carro")
        {
            motorEstradasScript.SpeedEstrada();
            carroPrincipal.GetComponent<AudioSource>().pitch = 1.6f;
        }
    }
}
