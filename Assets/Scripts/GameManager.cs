using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {


        //float poxXgeneracion = Random.Range(-rangoGeneracion, rangoGeneracion); examen
        //float posZgeneracion = Random.Range(-rangoGeneracion, rangoGeneracion); examen
        //Vector3 posAleatoria = new Vector3(poxXgeneracion, 0, posZgeneracion); examen
        //La instanciacion la hace Photon
        //Ojo el nombre lo busca en una carpeta que se llama Resources
        // Y es ahi donde tenemos que meter nuestros prefabs
        if (PhotonNetwork.IsMasterClient)
        {
            PhotonNetwork.Instantiate("BolaAmarilla", new Vector3(3.39f, 0.5600001f, -3.24f), Quaternion.identity);


        }

        else
        {
            PhotonNetwork.Instantiate("BolaVerde", new Vector3(3.35f, -0.56f, 2.96f), Quaternion.identity);
        }

        NewEnemy();
    }

    void NewEnemy()
    {
        //Espera 5 segundos y llama al método que instancia una fruta          
        PhotonNetwork.Instantiate("BolaRojaEnemigo", new Vector3(3.35f, -0.56f, 2.96f), Quaternion.identity);
        PhotonNetwork.Instantiate("BolaRojaEnemigoOrdenPuntosAleatorios1", new Vector3(-4.03f, -0.7620156f, -3.93f), Quaternion.identity);
    }
    
}


