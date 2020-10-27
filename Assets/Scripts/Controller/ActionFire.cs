using System.Collections.Generic;
using UnityEngine;

public class ActionFire : IAction
{
    #region PRIVATES

    private PlayerController _playerData;

    private Transform ObjectProjectil;

    private List<Rigidbody> _projeteis;

    #endregion

    public ActionFire(PlayerController playerData)
    {
        _playerData = playerData;

        _projeteis = new List<Rigidbody>();

        ObjectProjectil = new GameObject("Projecteis").transform;

        for (int i = 0; i < 30; i++)
        {
            Rigidbody projectil = MonoBehaviour.Instantiate(_playerData.Projectil, ObjectProjectil,false);

            projectil.gameObject.SetActive(false);

            _projeteis.Add(projectil);
            
        }
    }
    public void Execute()
    { 
        Vector3 mouseInput = Input.mousePosition;
        mouseInput.z = 10;

        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(mouseInput);
        mousePosition.z = 0;

        Vector3 projectileDelta = mousePosition - _playerData.transform.position;

        GetProjecteis().AddForce(projectileDelta.normalized * _playerData.GameData.ProjectileForce);
    } 

    private Rigidbody GetProjecteis()
    {
        Rigidbody projectil = null;
        for (int i = 0; i < _projeteis.Count; i++)
        {
            if (!_projeteis[i].gameObject.activeInHierarchy)
            {
                projectil = _projeteis[i];

                projectil.transform.position = _playerData.transform.position;

                projectil.gameObject.SetActive(true);

                break;
            } 
        }
        if(projectil == null)
        {
            projectil = MonoBehaviour.Instantiate(_playerData.Projectil, ObjectProjectil, false);

            projectil.transform.position = _playerData.transform.position;

            _projeteis.Add(projectil);
        }  
        return projectil;
    }
}