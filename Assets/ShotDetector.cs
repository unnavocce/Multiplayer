using UnityEngine;

public class ShotDetector : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Projectile")) // Assuming the tag of the projectile is "Projectile"
        {
            // Handle shot detection logic here
            Debug.Log("Shot detected!");
            // You can access other information from the projectile or perform additional actions
        }
    }
}
