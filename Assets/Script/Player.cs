using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    [Header("PlayerData")]
    PlayerData _playerData;

    [SerializeField]
    [Header("PlayerÇÃà⁄ìÆë¨ìx")]
    float _speed = 20;

    [SerializeField]
    [Header("PlayerÇ™éÛÇØÇÈçUåÇ")]
    int _damage;

    /// <summary>çÑëÃ</summary>
    Rigidbody _rb;


    void Start()
    {
        _rb = GetComponent<Rigidbody>();

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            _playerData.Damage(_damage);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Item")
        {
            _playerData.HPItem(2);
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Coin")
        {
            _playerData.AddCoin(10);
        }
    }
    void Update()
    {
        Move();
    }

    public void Move()
    {
        float horizontal = Input.GetAxis("Horizontal") * _speed * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * _speed * Time.deltaTime;

        _rb.AddForce(new Vector3(horizontal, 0, vertical), ForceMode.Impulse);
    }
}
