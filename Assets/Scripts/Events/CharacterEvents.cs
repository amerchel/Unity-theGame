using UnityEngine;
using UnityEngine.Events;

public class CharacterEvents
{
    //Character damaged and the value
    public static UnityAction<GameObject, int> characterDamaged;

    //Character healed and the value
    public static UnityAction<GameObject, int> characterHealed;
}