using System.Reflection.PortableExecutable;

namespace 생성자2
{
    enum MagicType
    {
        Fireball = 20,
        Icebolt = 15,
        Heal = 10
    }
    class Wizard
    {
        public int mp;
        public int intelligence;

        public Wizard()
        {
            mp = 100;
            intelligence = 30;
        }
    }

    internal class Program
    {
        static void CastSpell(MagicType magic, Wizard wizard)
        {
            if (wizard.mp >= (int)magic)
            {
                Console.WriteLine($"{magic} 시전! 마나가 {(int)magic} 줄어듭니다.");
                wizard.mp -= (int)magic;
            }
            else
            {
                Console.WriteLine($"{magic} 시전! 마나가 부족합니다.");
            }
        }
        static void Main(string[] args)
        {
            Wizard wizard = new Wizard();

            CastSpell(MagicType.Fireball, wizard);
            CastSpell(MagicType.Heal, wizard);

            Console.WriteLine($"남은 마나 : {wizard.mp}");
        }
    }
}
