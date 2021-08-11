using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Boss : MonoBehaviour
{
   
    [SerializeField] private int _damage;
    [SerializeField] private int _health;
    [SerializeField] private int _speed;
    [SerializeField] private Player _character;

    public int Damage { get => _damage; set => _damage = value; }
    public int Health { get => _health; set => _health = value; }
    public Player Character { get => _character; set => _character = value; }
    public int Speed { get => _speed; set => _speed = value; }

    public abstract void Attack();
    public abstract void Move();
    public abstract void Die();
}
