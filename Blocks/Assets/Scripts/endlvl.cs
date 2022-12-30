using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endlvl : MonoBehaviour
{
    public GameObject canva;
    public GameObject[] empty;
    public GameObject[] full;
    public GameObject next;
    public GameObject retry;

    public double percent;

    public void Update()
    {
        

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hole")
        {
            float total = (float)PlayerManager.instance.total.Length;
            float collected = (float)PlayerManager.instance.collidedList.Count;
            percent =collected /total * 100f;
            
            
            canva.SetActive(true);
            if (percent > 50 )
            {
                retry.SetActive(false);
                next.SetActive(true);
                empty[0].SetActive(false);
                full[0].SetActive(true);
                if( percent > 75)
                {
                    empty[1].SetActive(false);
                    full[1].SetActive(true);
                    if (percent == 100)
                    {

                        empty[2].SetActive(false);
                        full[2].SetActive(true);
                    }
                }
                
            }
          
        }
       
    }
    
}
