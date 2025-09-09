using UnityEngine;

[CreateAssetMenu(fileName = "Animal_SO", menuName = "Animal/AnimalData")]
public class Animal_SO : ScriptableObject
{
    public string animalName;
    public Sprite animalSprite;
    public AudioClip animalSound;
    [TextArea] public string fact;
}

