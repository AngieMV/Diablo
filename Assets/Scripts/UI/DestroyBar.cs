using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBar : MonoBehaviour
{
    [SerializeField]
    private HealthValue health;

    private void Update() 
    {
        if (health == null)
        {
            Destroy(gameObject);
        }    
    }
}
