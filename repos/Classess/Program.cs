// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
SqlServer sserver = new SqlServer();
sserver.Add();
class Database
{
    
    public virtual void Add()
    {
        Console.WriteLine("ANAN");
    }

}
class SqlServer:Database
{
    public override void Add()
    {
        Console.WriteLine("SQL");
        base.Add();
    }
    
}
abstract class DatabaseBase
{
    public void Add()
    {
        Console.WriteLine("baban lan bu");
    }
    public abstract void Delete();
}
class MySqlServer : DatabaseBase
{
    public override void Delete()
    {
        throw new NotImplementedException();
    }
}