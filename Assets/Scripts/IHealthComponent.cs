using System;

namespace EntitiesHomework
{
    public interface IHealthComponent
    {
        int Health { get; }
        void OnPlayerAttacked(int damage);
    }
}