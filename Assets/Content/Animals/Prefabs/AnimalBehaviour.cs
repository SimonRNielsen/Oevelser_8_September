using UnityEngine;

public class AnimalBehaviour : MonoBehaviour
{
    [Header("Datasæt")]
    [SerializeField] private Animal_SO animalData;

    [Header("Indstillinger")]
    [SerializeField, Range(1, 10), Tooltip("Mængden af mad")] private int foodItems = 3;
    [SerializeField, Range(10, 60), Tooltip("Tidsebegrænsning")] private int timeLimit = 30;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
