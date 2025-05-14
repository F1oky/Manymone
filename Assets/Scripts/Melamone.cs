
public class Melamone
{
    public string name;
    public int hp;
    public int maxHp;
    public int power;

    public Melamone(string name, int maxHp, int power)
    {
        this.name = name;
        this.maxHp = maxHp;
        this.hp = maxHp;
        this.power = power;
    }

    public void TakeDamage(int dmg)
    {
        hp -= dmg;
        if (hp < 0) hp = 0;
    }

    public bool IsDefeated() => hp <= 0;
}
