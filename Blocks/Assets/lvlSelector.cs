using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lvlSelector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OpendScene()
    {
        SceneManager.LoadScene("scene1");
    }
}
