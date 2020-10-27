 using System.Collections; 
using UnityEngine;

public class Projectil : MonoBehaviour
{
    [SerializeField] private GameData _gameData; 

    private void OnEnable()
    {
        StartCoroutine(_fire());
    }

    private void OnDisable()
    {
        GetComponent<Rigidbody>().velocity = Vector3.zero;
    }

    IEnumerator _fire()
    {
        yield return new WaitForSeconds(_gameData.LifeTime);
        gameObject.SetActive(false);
    }
}
