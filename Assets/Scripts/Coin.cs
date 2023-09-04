using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] float _RotationSpeed;
    void Update()
    {
        transform.Rotate(0, _RotationSpeed * Time.deltaTime, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<CoinManager>().AddOne();
        Destroy(gameObject);
    }
}
