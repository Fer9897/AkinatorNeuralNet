using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Akinator : UnityEngine.MonoBehaviour
{
    NeuralNetwork.NeuralNet net = new NeuralNetwork.NeuralNet(10, 20, 14);
    string[] nombresAlumnos = new string[14];
    public string[] preguntas = new string[10];
    public string[] respuestas = new string[10];
    
    string path = "Assets/Datasets.txt";

    private System.Collections.Generic.List<NeuralNetwork.DataSet> dataSets = new System.Collections.Generic.List<NeuralNetwork.DataSet>();
    double[] respuesta;
    
    public UnityEngine.UI.Text pregunta;
    int i = 0;

    public UnityEngine.GameObject preguntaPanel;
    public UnityEngine.GameObject respuestaPanel;


    // Start is called before the first frame update
    void Start()
    {
        StreamReader streamReader = new StreamReader(path);

        while (!streamReader.EndOfStream)
        {
            double[] datosEntrada = new double[10];
            for (int i = 0; i < datosEntrada.Length; i++)
            {
                string linea = streamReader.ReadLine();
                datosEntrada[i] = System.Double.Parse(linea);
            }
            double[] datosSalida = new double[14];
            for (int i = 0; i < datosSalida.Length; i++)
            {

                string linea = streamReader.ReadLine();
                datosSalida[i] = double.Parse(linea);
            }
            NeuralNetwork.DataSet dataSet = new NeuralNetwork.DataSet(datosEntrada, datosSalida);
            dataSets.Add(dataSet);
        }
        net.Train(dataSets, 0.1);

        nombresAlumnos[0] = "Orlando";
        nombresAlumnos[1] = "DOC";
        nombresAlumnos[2] = "Alex";
        nombresAlumnos[3] = "Fernando";
        nombresAlumnos[4] = "Raul";
        nombresAlumnos[5] = "Luis";
        nombresAlumnos[6] = "Edgardo";
        nombresAlumnos[7] = "Mauricio";
        nombresAlumnos[8] = "Mauro";
        nombresAlumnos[9] = "Juan";
        nombresAlumnos[10] = "Alda";
        nombresAlumnos[11] = "Martin";
        nombresAlumnos[12] = "Arturo";
        nombresAlumnos[13] = "Chema";

        preguntas[0] = "¿Usa lentes?";
        preguntas[1] = "¿Es foraneo?";
        preguntas[2] = "¿Es de cabello chino?";
        preguntas[3] = "¿Es gordo?";
        preguntas[4] = "¿Es programador?";
        preguntas[5] = "¿Es artista?";
        preguntas[6] = "¿Fuma?";
        preguntas[7] = "¿Se encuentra realizando sus prácticas profesionales?";
        preguntas[8] = "¿Es alto?";
        preguntas[9] = "¿Tiene barba?";

        pregunta.text = preguntas[0];
    }

    public void Pasar_Pregunta()
    {
        i++;
        if (i < 10)
        {
            pregunta.text = preguntas[i];
        }
        else
        {
            respuestaPanel.SetActive(true);
            preguntaPanel.SetActive(false);
            respuesta = new double[10];
            for (int i = 0; i < respuestas.Length; i++)
            {
                if (respuestas[i] == "Si")
                {
                    respuesta[i] = 1.0;
                } else if (respuestas[i] == "Tal vez")
                {
                    respuesta[i] = 0.5;
                } else
                {
                    respuesta[i] = 0.0;
                }
            }
            double[] salida = new double[14];
            salida = net.Compute(respuesta);
            double mayor = 0;
            int iteracion = 0;
            for (int i = 0; i < salida.Length; i++)
            {
                if (salida[i] > mayor)
                {
                    mayor = salida[i];
                    iteracion = i;
                }
            }
            UnityEngine.GameObject.Find("TextoRespuestaXDDx").GetComponent<UnityEngine.UI.Text>().text = nombresAlumnos[iteracion];
            
        }
    }

    public void Si()
    {
        respuestas[i] = "Si";
    }

    public void No()
    {
        respuestas[i] = "No";
    }

    public void Talvez()
    {
        respuestas[i] = "Tal vez";
    }
    public void SubirRespuestaCorrecta(UnityEngine.UI.Dropdown o)
    {
        double[] salidasDeseadas = new double[14];
        for (int i = 0; i < salidasDeseadas.Length; i++)
        {
            salidasDeseadas[i] = 0.0;
        }
        salidasDeseadas[o.value - 1] = 1.0;
        dataSets.Add(new NeuralNetwork.DataSet(respuesta, salidasDeseadas));
        net.Train(dataSets, 0.1);
        StreamWriter writter = new StreamWriter(path, true);
        
        foreach (double item in respuesta)
        {
            writter.Write(writter.NewLine);
            writter.Write(item);
            
        }
        foreach (double item in salidasDeseadas)
        {
            writter.Write(writter.NewLine);
            writter.Write(item);
            
        }
        
        //writter.
        writter.Close();
        ReiniciarDatos(ref o);
    }
    private void ReiniciarDatos(ref UnityEngine.UI.Dropdown o)
    {
        i = 0;
        o.value = 0;
        preguntaPanel.SetActive(true);
        respuestaPanel.SetActive(false);
        pregunta.text = preguntas[i];
        for (int i = 0; i < respuestas.Length; i++)
        {
            respuestas[i] = "";
        }
    }
}