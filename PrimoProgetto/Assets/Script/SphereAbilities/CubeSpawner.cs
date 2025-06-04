using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _cubeprefab;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private Color _color;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            GameObject cubeInstance = Instantiate(_cubeprefab, _spawnPoint.position, Quaternion.identity);
            cubeInstance.GetComponent<Renderer>().material.color = _color;
        }
    }
}
