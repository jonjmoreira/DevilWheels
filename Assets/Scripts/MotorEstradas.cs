using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotorEstradas : MonoBehaviour
{
    public GameObject motorEstradas;
    public GameObject[] containerEstradas;
    public GameObject Estrada;

    public float speed;

    public int contadorEstradas;

    public bool contagemRegressivaTermino;
    public bool jogoFinalizado;

    void Start()
    {
        jogoFinalizado = false;
        GameStart();
    }

    public void GameStart()
    {
        CriarEstradas();
        SpeedEstrada();
        contagemRegressivaTermino = false;
    }

    // Update is called once per frame
    void Update()
    {
        if ( jogoFinalizado == false && contagemRegressivaTermino ) 
        {
            motorEstradas.transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }

    public void CriarEstradas()
    {

        int numSeletorEstrada = Random.Range(0,5);

        Estrada = GameObject.Instantiate(containerEstradas[numSeletorEstrada],
                                                new Vector3( 0, 0, 0 ),
                                                transform.rotation);

        contadorEstradas++;

        Estrada.SetActive(true);
        Estrada.name = "Estrada" + contadorEstradas;
        Estrada.transform.parent = motorEstradas.transform;

        GameObject pecaAux = GameObject.Find( "Estrada" + (contadorEstradas - 1) );

        Estrada.transform.position = new Vector3(
            transform.position.x,
            pecaAux.GetComponent<Renderer>().bounds.size.y +
            pecaAux.transform.position.y,
            pecaAux.transform.position.z
            );
    }

    public void SpeedStop()
    {
        speed = 0;
    }

    public void SpeedCalcada()
    {
        speed = 5;
    }

    public void SpeedEstrada()
    {
        speed = 15;
    }

    public void SpeedCarroMal()
    {
        speed = 3;
    }

    public void FinalizarJogo()
    {
        SpeedStop();
    }
}
