﻿using UnityEngine.EventSystems;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    private Transform _firePoint;

    [SerializeField] private GameObject _bulletPrefab;

    private float _bulletForce = 10f;


    void Start()
    {
        _firePoint = GameObject.Find("FirePoint").GetComponent<Transform>();
    }

    void Update()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }
        
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(_bulletPrefab, _firePoint.position, _firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(_firePoint.up * _bulletForce, ForceMode2D.Impulse);
    }
}