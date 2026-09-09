using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Data/Game/PlayerData")]

public class PlayerDataSo : ScriptableObject
{
    [Header("Valores iniciales")]
    [Range(100, 1000)] public float moveSpeed = 100f;
    [Range(1, 7)] public float verticalSize = 2f;

    [Header("Movimiento")]
    public KeyCode moveUp;
    public KeyCode moveDown;
    public KeyCode moveRight;
    public KeyCode moveLeft;

    [Header("Color")]
    public Color color = Color.white;
}
