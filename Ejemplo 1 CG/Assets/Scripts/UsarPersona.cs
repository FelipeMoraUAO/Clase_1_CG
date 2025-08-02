using UnityEngine;
using System;
using System.Collections.Generic;
using PakagePersona;


public class UsarPersona : MonoBehaviour
{
    List<Estudiante> ListaE=new List<Estudiante>();//Creacion de lista

    // Start is called before the first frame update
    void Start()
    {
        Estudiante e1 = new Estudiante("Multimedia", "235486", "Andres Mora", "andres_f.mora@uao.edu.co", "Cra 3N #48-65"); //Creacion de Estudiante
        ListaE.Add(e1); //Anadir estudiante a la lista

        Estudiante e2 = new Estudiante("Mercadeo", "2645148", "Andres Mora", "andres_v.mora@uao.edu.co", "Cra 3N #48-65");
        ListaE.Add(e2);

        for (int i = 0; i < ListaE.Count; i++)
        {
            Debug.Log(ListaE[i].CarreraEstu + " " + ListaE[i].CarreraEstu);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
