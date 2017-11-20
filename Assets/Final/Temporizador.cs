using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Temporizador : MonoBehaviour {

    public Text contador;
    public Text fin;
    private float tiempo = 10f;

	void Start () {

        contador.text = "Time: " + tiempo;
        fin.enabled = false;
		
	}

    private void Update()
    {
        tiempo -= Time.deltaTime;
        contador.text = "Time: " + tiempo.ToString("f0");

        if(tiempo <= 0)
        {
            contador.text = "0";
                fin.enabled = true;
        }

    }

}
