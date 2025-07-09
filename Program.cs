class Weapon
{
    private const string NotEnoughBulletMessage = "Недостаточно пуль для выстрела";

    private readonly int _bulletCountPerShoot = 1;
    private int _bullets;

    public Weapon(int bullets, int bulletCountPerShoot)
    {
        if (bullets <= 0)
            throw new ArgumentOutOfRangeException(nameof(bullets));

        if (bulletCountPerShoot <= 0)
            throw new ArgumentOutOfRangeException(nameof(bulletCountPerShoot));

        _bullets = bullets;
        _bulletCountPerShoot = bulletCountPerShoot;
    }

    private bool СanShoot => _bullets >= _bulletCountPerShoot;

    public void Shoot()
    {
        if (СanShoot == false)
            throw new Exception(NotEnoughBulletMessage);

        _bullets -= _bulletCountPerShoot;
    }
}