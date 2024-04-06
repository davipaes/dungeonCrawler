using UnityEngine;

public class CollectibleKey : MonoBehaviour
{
    public Door door; 

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            door.Unlock();
        }
    }
}
