using UnityEngine;

public class Bala : MonoBehaviour
{
    [Header("Velocidad del Disparo")]
    [SerializeField] private float velocidad = 10f;

    [Header("Tiempo en Destruirse")]
    [SerializeField] private float tiempoVida = 3f;

    private void OnTriggerEnter(Collider colision)
    {
        if (colision.CompareTag("Asteroide"))
        {
            Destroy(colision.gameObject);
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        Destroy(gameObject, tiempoVida);
    }

    void Update()
    {
        transform.Translate(Vector3.up * velocidad * Time.deltaTime);
    }
}
