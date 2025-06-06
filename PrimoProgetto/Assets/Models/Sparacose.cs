using UnityEngine;

public class Sparacose : MonoBehaviour
{
    [SerializeField] private GameObject _projectilePrefab; // Prefab del proiettile
    [SerializeField] private Transform _spawnPoint; // Punto di spawn del proiettile
    [SerializeField] private float _shootForce = 20f; // Forza di sparo
    [SerializeField] private float _shootInterval = 2f; // Intervallo tra gli spari in secondi
    
    private float _shootTimer = 0f;
    
    void Start()
    {
        // Inizia il timer a 0
        _shootTimer = 0f;
    }
    
    void Update()
    {
        // Incrementa il timer con deltaTime
        _shootTimer += Time.deltaTime;
        
        // Quando il timer raggiunge l'intervallo, spara
        if (_shootTimer >= _shootInterval)
        {
            Shoot();
            _shootTimer = 0f; // Resetta il timer
        }
    }
    
    private void Shoot()
    {
        if (_projectilePrefab == null || _spawnPoint == null)
        {
            Debug.LogWarning("Projectile Prefab o Spawn Point non assegnati!");
            return;
        }
        
        // Crea il proiettile
        GameObject projectile = Instantiate(_projectilePrefab, _spawnPoint.position, _spawnPoint.rotation);
        
        // Ottieni il Rigidbody del proiettile
        Rigidbody projectileRb = projectile.GetComponent<Rigidbody>();
        
        if (projectileRb == null)
        {
            projectileRb = projectile.AddComponent<Rigidbody>();
        }
        
        // Applica la forza nella direzione forward dello spawn point
        projectileRb.AddForce(_spawnPoint.forward * _shootForce, ForceMode.Impulse);
        
        // Distruggi il proiettile dopo 5 secondi
        Destroy(projectile, 5f);
    }
}