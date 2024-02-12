using System.Collections.Generic;
using UnityEngine;

public class SwitchWeapons : MonoBehaviour
{
    [SerializeField] private List<WeaponScript> _weapons;

    private WeaponScript _currentWeapon;

    private void Start()
    {
        foreach (var weapon in _weapons)
        {
            weapon.gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            SwitchWeapon(0);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SwitchWeapon(1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SwitchWeapon(2);
        }
    }

    private void SwitchWeapon(int index)
    {
        if (_weapons[index] == null) return;
        _currentWeapon?.gameObject.SetActive(false);
        _weapons[index].gameObject.SetActive(true);
        _currentWeapon = _weapons[index];
    }
}
