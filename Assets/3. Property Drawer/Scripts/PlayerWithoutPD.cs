using System;
using UnityEngine;

public enum AttackStrength2 { LOW, MEDIUM, HARD, LETHAL }

[Serializable]
public class Attack2 {
    public string name = "Test";
    public float range = 1f;
    public AttackStrength2 strength = AttackStrength2.LOW;
}

public class PlayerWithoutPD : MonoBehaviour {
    public int playerId;
    public Attack2[] attacks;

}
