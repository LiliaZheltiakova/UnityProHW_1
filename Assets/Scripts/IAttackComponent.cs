namespace EntitiesHomework
{
    public interface IAttackComponent
    {
        delegate void OnPlayerAttackedDelegate(int attack);
        int AttackRange { get; }
        void Attack();
    }
}