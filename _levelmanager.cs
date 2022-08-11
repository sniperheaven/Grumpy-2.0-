using UnityEngine;
using UnityEngine.SceneManagement;

public class _levelmanager : MonoBehaviour
{
    private static int _nextLevelIndex = 1;
    private Monster[] _enemies;

    private void OnEnable()
    {
        _enemies = FindObjectsOfType <Monster>();
    }
    void Update ()
    {
        foreach (Monster monster in _enemies)
        {
            if (monster != null)
                return;
        }
        Debug.Log("you destroyed the monsters");

        _nextLevelIndex++;
        string nextLevelName = "Level" + _nextLevelIndex;
        SceneManager.LoadScene(nextLevelName);
    }
}