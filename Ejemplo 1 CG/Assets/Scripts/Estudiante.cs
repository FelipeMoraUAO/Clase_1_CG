using UnityEngine;
using System;
using TMPro;

namespace PakagePersona
{
    [Serializable]
    public class Estudiante 
    {
        private string carreraEstu;
        private string codigoEstu;

        public Estudiante()
        {

        }

        public Estudiante(string carreraEstu, string codigoEstu, string nameP, string mailP, string dirP)//Para heredar se ponen los atributos del padre
        //: base( nameP,  mailP,  dirP)//Para heredar se crea esta base con los atributos pero sin el tipo de dato
        {
            this.carreraEstu = carreraEstu;
            this.codigoEstu = codigoEstu;
        }

        public string CarreraEstu { get => carreraEstu; set => carreraEstu = value; }
        public string CodigoEstu { get => codigoEstu; set => codigoEstu = value; }
    }

}