using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        // init game systems
    }

    public void StartGame() { }
    public void PauseGame() { }
    public void GameOver() { }
}
