using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private Transform enemy;
    private void Update()
    {
        transform.localScale = enemy.transform.localScale;
    }
}
