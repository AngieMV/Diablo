using UnityEngine;

[CreateAssetMenu(menuName = "Scriptables/Variables/Float", fileName = "Float_")]
public class RefFloat : RefVariable<float> {

    [SerializeField]
    public float MinValue;

    [SerializeField]
    public float MaxValue;

}