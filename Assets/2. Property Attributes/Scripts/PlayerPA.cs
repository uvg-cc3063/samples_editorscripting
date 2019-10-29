using UnityEngine;

public class PlayerPA : MonoBehaviour {
    [Header("Attack")]
    [Range(0, 5)]
    public float attackRange = 2f;
    public float strength = 5f;
    [HideInInspector]
    public float attackSpeed = 2f;
    [Space]

    [Header("Defense")]
    [Range(0, 5)]
    [Tooltip("Hits take points from shield first, when shield is 0 they take points from health")]
    public float shield = 4f;
    [SerializeField] private float health = 20;

    [ContextMenu("Reset to default values")]
    public void ResetToDefault() {
        attackRange = 2f;
        strength = 5f;
        attackSpeed = 2f;
        shield = 4f;
        health = 20;
    }

}
