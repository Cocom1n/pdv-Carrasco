using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Flowermanager : MonoBehaviour
{
    public string sigEscena;
    //metodo que pregunta si todas las flores fueron recolectadas
    public void AllFlowersCollected()
    {
        if(transform.childCount==1)
        {
            Debug.Log("Todas las flores fueron recollectadas");
            SceneManager.LoadScene(sigEscena);
        }
    }
}
