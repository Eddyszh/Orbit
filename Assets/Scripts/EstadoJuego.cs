using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class EstadoJuego : MonoBehaviour {

    //public int puntuacionMaxima = 0;
   // public ShipHealth salud;
    public Transform nave;

    public static EstadoJuego estadoJuego;

    private string rutaArchivo;

    void Awake()
    {
        rutaArchivo = Application.persistentDataPath + "/datos.dat";
        /*if (estadoJuego == null)
        {
            estadoJuego = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (estadoJuego != this)
        {
            Destroy(gameObject);
        }*/
    }

    // Use this for initialization
    void Start()
    {
        Cargar();
       // salud.VerificarSalud();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Guardar()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(rutaArchivo);

        DatosAGuardar datos = new DatosAGuardar();
       // datos.puntuacionMaxima = puntuacionMaxima;
        //datos.salud = salud;
        datos.nave = nave;

        bf.Serialize(file, datos);

        file.Close();
    }

    void Cargar()
    {
        if (File.Exists(rutaArchivo))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(rutaArchivo, FileMode.Open);

            DatosAGuardar datos = (DatosAGuardar)bf.Deserialize(file);

           // puntuacionMaxima = datos.puntuacionMaxima;
            //salud = datos.salud;
            nave = datos.nave;

            file.Close();
        }
        else
        {
            //puntuacionMaxima = 0;
            Guardar();
        }
    }
}

[System.Serializable]
class DatosAGuardar
{
   // public int puntuacionMaxima;
    //public ShipHealth salud;
    public Transform nave;
}

