using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBar : MonoBehaviour
{
    [SerializeField]
    private HealthValue _Health;

    private void Update() 
    {
        if (_Health == null)
        {
            Destroy(gameObject);
        }    
    }
}
