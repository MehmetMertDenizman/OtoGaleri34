// See https://aka.ms/new-console-template for more information
using Interfaces;

Console.WriteLine("Hello, World!");

IWorker[] workers = new IWorker[]
{
    new Manager(),
    new Worker(),
    new Robot(),
};
foreach (var worker in workers)
{
    worker.Work();
}
interface IWorker
{
    void Work();
    
}
interface IEat
{
    void Eat();
}
interface ISalary
{
    void Salary();
}
class Manager : IWorker, IEat, ISalary
{
    public void Eat()
    {
        throw new NotImplementedException();
    }
    public void Salary()
    {
        throw new NotImplementedException();
    }
    public void Work()
    {
        throw new NotImplementedException();
    }
}
class Worker : IWorker, ISalary, IEat
{
    public void Eat()
    {
        throw new NotImplementedException();
    }
    public void Salary()
    {
        throw new NotImplementedException();
    }
    public void Work()
    {
        throw new NotImplementedException();
    }
}
class Robot : IWorker
{
    
  
    public void Work()
    {
        throw new NotImplementedException();
    }
    public void Robo()
    {

    }
}
