﻿using UnityEngine;

namespace Source.Enemy
{
    public abstract class Enemy : MonoBehaviour
    {
        protected Transform _transform;

        protected int _health;
        protected int _goldCoinCount;
        protected int _damagePower;

        private void Awake()
        {
            _transform = transform;
        }
        protected void SetParameters(EnemyParameters parameters)
        {
            _health = parameters.health;
            _goldCoinCount = parameters.goldCoinCount;
            _damagePower = parameters.damagePower;
        }

    }
}

