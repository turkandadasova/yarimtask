namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Weapon weapon = new Weapon();
            weapon.BulletCapasity = 20;
            weapon.BulletNumber = 15;
            weapon.GetRemainBulletCount();
            weapon.Reload();
            weapon.AddBullet();




            bool f = false;
            string operation;
            do
            {
                Console.WriteLine("0 - İnformasiya almaq üçün  " +
                    "1.Shoot metodu üçün" +
                    " 2.GetRemainBulletCount metodu üçün" +
                    "3.Reload metodu üçün" +
                    "4.ChangeFireMode metodu üçün" +
                    "5.Proqramdan dayandırmaq üçün");
                operation = Console.ReadLine();

                switch (operation)
                {
                    case "0";

                }
            }while (!f);


        }
    }
}