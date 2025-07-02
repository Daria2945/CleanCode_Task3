class Weapon
{
    private readonly int _bulletCountPerShoot = 1;
    private int _bullets;

    private bool _canShoot => _bullets >= _bulletCountPerShoot;

    public void Shoot()
    {
        if (_canShoot)
            _bullets -= _bulletCountPerShoot;
    }
}