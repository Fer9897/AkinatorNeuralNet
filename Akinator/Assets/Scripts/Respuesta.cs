using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Respuesta : MonoBehaviour
{
    // Panel pregunta
    public GameObject pregunta1;
    public GameObject pregunta2;
    public GameObject pregunta3;
    public GameObject pregunta4;
    public GameObject pregunta5;
    public GameObject pregunta6;
    public GameObject pregunta7;
    public GameObject pregunta8;
    public GameObject pregunta9;
    public GameObject pregunta10;

    //private float[] respuesta = new float[10];

    [SerializeField]
    private float respuesta1 = 0;
    private float respuesta2 = 0;
    private float respuesta3 = 0;
    private float respuesta4 = 0;
    private float respuesta5 = 0;
    private float respuesta6 = 0;
    private float respuesta7 = 0;
    private float respuesta8 = 0;
    private float respuesta9 = 0;
    private float respuesta10 = 0;

    [SerializeField]
    private Text[] textoPregunta = new Text[10];

    [SerializeField]
    private Text[] textoResultado = new Text[10];
    
    // Si
    public void Resp1Si()
    {
        respuesta1 = 1.0f;
    }
    public void Resp2Si()
    {
        respuesta2 = 1.0f;
    }
    public void Resp3Si()
    {
        respuesta3 = 1.0f;
    }
    public void Resp4Si()
    {
        respuesta4 = 1.0f;
    }
    public void Resp5Si()
    {
        respuesta5 = 1.0f;
    }
    public void Resp6Si()
    {
        respuesta6 = 1.0f;
    }
    public void Resp7Si()
    {
        respuesta7 = 1.0f;
    }
    public void Resp8Si()
    {
        respuesta8 = 1.0f;
    }
    public void Resp9Si()
    {
        respuesta9 = 1.0f;
    }
    public void Resp10Si()
    {
        respuesta10 = 1.0f;
    }

    // No
    public void Resp1No()
    {
        respuesta1 = 0;
    }
    public void Resp2No()
    {
        respuesta2 = 0;
    }
    public void Resp3No()
    {
        respuesta3 = 0;
    }
    public void Resp4No()
    {
        respuesta4 = 0;
    }
    public void Resp5No()
    {
        respuesta5 = 0;
    }
    public void Resp6No()
    {
        respuesta6 = 0;
    }
    public void Resp7No()
    {
        respuesta7 = 0;
    }
    public void Resp8No()
    {
        respuesta8 = 0;
    }
    public void Resp9No()
    {
        respuesta9 = 0;
    }
    public void Resp10No()
    {
        respuesta10 = 0;
    }

    // Tal vez
    public void Resp1Tv()
    {
        respuesta1 = 0.5f;
    }
    public void Resp2Tv()
    {
        respuesta2 = 0.5f;
    }
    public void Resp3Tv()
    {
        respuesta3 = 0.5f;
    }
    public void Resp4Tv()
    {
        respuesta4 = 0.5f;
    }
    public void Resp5Tv()
    {
        respuesta5 = 0.5f;
    }
    public void Resp6Tv()
    {
        respuesta6 = 0.5f;
    }
    public void Resp7Tv()
    {
        respuesta7 = 0.5f;
    }
    public void Resp8Tv()
    {
        respuesta8 = 0.5f;
    }
    public void Resp9Tv()
    {
        respuesta9 = 0.5f;
    }
    public void Resp10Tv()
    {
        respuesta10 = 0.5f;
    }

    // Reset
    public void Reiniciar()
    {
        respuesta1 = 0;
        respuesta2 = 0;
        respuesta3 = 0;
        respuesta4 = 0;
        respuesta5 = 0;
        respuesta6 = 0;
        respuesta7 = 0;
        respuesta8 = 0;
        respuesta9 = 0;
        respuesta10 = 0;
    }

    // Resultados
    public void Resultados()
    {
        textoResultado[0].text = textoPregunta[0].text + ":  " + respuesta1.ToString();
        textoResultado[1].text = textoPregunta[1].text + ":  " + respuesta2.ToString();
        textoResultado[2].text = textoPregunta[2].text + ":  " + respuesta3.ToString();
        textoResultado[3].text = textoPregunta[3].text + ":  " + respuesta4.ToString();
        textoResultado[4].text = textoPregunta[4].text + ":  " + respuesta5.ToString();
        textoResultado[5].text = textoPregunta[5].text + ":  " + respuesta6.ToString();
        textoResultado[6].text = textoPregunta[6].text + ":  " + respuesta7.ToString();
        textoResultado[7].text = textoPregunta[7].text + ":  " + respuesta8.ToString();
        textoResultado[8].text = textoPregunta[8].text + ":  " + respuesta9.ToString();
        textoResultado[9].text = textoPregunta[9].text + ":  " + respuesta10.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        
        textoPregunta[0].text = "¿Usa lentes?";
        textoPregunta[1].text = "¿Es foraneo?";
        textoPregunta[2].text = "¿Es chino?";
        textoPregunta[3].text = "¿Es gordo?";
        textoPregunta[4].text = "¿Es programador?";
        textoPregunta[5].text = "¿Es artista?";
        textoPregunta[6].text = "¿Fuma?";
        textoPregunta[7].text = "¿Hace practicas?";
        textoPregunta[8].text = "¿Es alto?";
        textoPregunta[9].text = "¿Tiene barba (bien)?";
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
