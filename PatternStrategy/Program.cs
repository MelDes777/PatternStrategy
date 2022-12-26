using PatternStrategy;
using PatternStrategy.Strategies;

Hero hero = new Hero("Squidward");

hero.Attack();

hero.SetWeapon(new Broom());

hero.Attack();

Console.ReadLine();