class Weapon
{
    private readonly int _bulletCountPerShoot = 1;
    private int _bullets;

    public bool CanShoot() =>
        _bullets > 0 && _bullets >= _bulletCountPerShoot;

    public void Shoot() =>
        _bullets -= _bulletCountPerShoot;
}