// //Jogo
// Edjalma edjalma = new Edjalma();
// Travis travis = new Travis();
// Sword sword = new Sword();
// travis.Weapon = sword;
// travis.Attack(edjalma);
// Console.WriteLine(edjalma.Life);

// public abstract class Entity
// {
//     public string Name {get; protected set;} //Dano da arma não pode ser altarada fora
//     public int Life {get;protected set;}
//     public int Damage {get; protected set;}
//     public Weapon Weapon {get;set;}
    
//     public abstract void Attack(Entity target);
//     public abstract void ReceiveDamage(int damage);
// }

// public abstract class Weapon
// {
//     public string Name {get; protected set;}
//     public int Damage {get; protected set;}
// }

// public class Edjalma : Entity
// {

//     public int Shield { get; private set; }

//     public Edjalma()
//     {
//         this.Name = "Edjalma";
//         this.Life = 180;
//         this.Damage = 10;
//         this.Shield = 40;
//     }

//     public override void Attack(Entity target)
//     {
//         int damage = this.Damage / 2
//             + this.Weapon.Damage * 2;
//         target.ReceiveDamage(damage);
//     }
//     public override void ReceiveDamage(int damage)
//     {
//         if(this.Shield > damage)
//         {
//             this.Shield = 0;
//             return;
//         }
//         else
//         {
//             damage -= this.Shield;
//             this.Shield = 0;
//         }
//         if (damage < 5)
//             return;
//         this.Life -= damage;
//     }
// }

// public class Travis : Entity
// {
//     public Travis()
//     {
//         this.Name = "Travis";
//         this.Life = 20;
//         this.Damage = 80;
//     }

//     public override void Attack(Entity target)
//     {
//         int damage = 2*(Weapon?.Damage?? 0)
//             +2*this.Damage
//             + this.Weapon.Damage * 2;
//         target.ReceiveDamage(damage);
//     }
//     public override void ReceiveDamage(int damage)
//     {
//         if (damage < 5)
//             return;
//         this.Life -= damage;
//     }
// }

// public class Sword : Weapon
// {
//     public Sword()
//     {
//         this.Name = "Espada";
//         this.Damage = 5;
//     }
// }

// E, OU, NÃO, entradas

Input a = new Input();
Input b = new Input();
Input c = new Input();
AndGate and = new AndGate();
OrGate or = new OrGate();
NotGate not = new NotGate();

a.Connect(and);
b.Connect(and);
c.Connect(or);
and.Connect(or);
or.Connect(not);

b.Input = true;
c.input = true;

Console.WriteLine(not.Output);

public abstract class Gates
{
    public bool Input {get;set;}
    public bool Output {get;set;}
    public abstract void Connect([Optional]Gates gate);
}

public class Input : Gates
{
    public Input()
    {
        this.Output = this.Input;
    }
}

public class AndGate : Gates
{
    public AndGate()
    {
        this.Input = 
    }
}

public class OrGate : Gates
{
    ||
}

public class NotGate : Gates
{
    !
}