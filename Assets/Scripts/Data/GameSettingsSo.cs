using UnityEngine;

[CreateAssetMenu(fileName = "GameSettings", menuName = "Data/Game/GameSettings")]

public class GameSettingsSo : ScriptableObject
{
    [Header("Partida")]
    public int pointsToWin = 3;

    [Header("Temporizador")]
    public float timer = 20;
}
