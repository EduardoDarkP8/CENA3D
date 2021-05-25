using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorRandom : MonoBehaviour
{

    public Color corInicial = Color.green;
  
    public float tempoParaTrocar = 1;
    public float velocidadeCor = 122;

    Material materialObjeto;
    Color corRandom;
    float timer;

    void Start()
    {
        materialObjeto = GetComponent<MeshRenderer>().material;
        materialObjeto.color = corInicial;
        timer = 0;
        corRandom = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
        
        
    }

    void Update()
    {
        materialObjeto.color = Color.Lerp(materialObjeto.color, corRandom, Time.deltaTime * velocidadeCor);
        timer += Time.deltaTime;
        if (timer > tempoParaTrocar)
        {
            timer = 0;
           
                corRandom = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
                
            
        }
    }
}
