using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float maxTime = 90.0F;
    private float countdown = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        countdown = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        Debug.Log("Restan: " + countdown);
        if(countdown <= 0)
        {
            Moneda.cantMonedas = 0;
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);
        }
    }
}
