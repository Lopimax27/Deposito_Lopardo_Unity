using UnityEngine;

public class CubeGenerator : MonoBehaviour
{
    [SerializeField] private GameObject _cubeprefab;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private Color _color;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject cubeInstance = Instantiate(_cubeprefab, _spawnPoint.position, Quaternion.identity);
            cubeInstance.GetComponent<Renderer>().material.color = _color;
        }
    }
}
