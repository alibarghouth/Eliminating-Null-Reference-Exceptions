
namespace Eliminating_Null_Reference_Exceptions {
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCharacter ali = new PlayerCharacter(new DiamondSkinDefence()) { Name = "ali"};
            PlayerCharacter ahmad = new PlayerCharacter(new IronBonesDefence()) { Name = "ahmad"};
            PlayerCharacter @null = new PlayerCharacter(null);
            ali.Hits(10);
            ahmad.Hits(10);
            @null.Hits(10);
            Console.ReadLine(); 
        }
    }
}