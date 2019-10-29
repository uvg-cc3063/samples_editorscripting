using System;
using UnityEngine;

public enum AttackStrength { LOW, MEDIUM, HARD, LETHAL }

[Serializable]
public class Attack {
    public string name = "Test";
    public float range = 1f;
    public AttackStrength strength = AttackStrength.LOW;
}

public class PlayerWithPD : MonoBehaviour {
    public int playerId;
    public Attack[] attacks;

}
