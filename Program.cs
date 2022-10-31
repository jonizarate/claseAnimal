using claseAnimal;

Animal miAnimal = new Animal("Delfino","Delfin",30,85.5,1.50, "Delphinus delphis","peces pequeños","11 meses de gestacion",false,true,true);

if (miAnimal.PuedeCaminar())
{
    Console.WriteLine("puede caminar");
}
else
{
    Console.WriteLine("no puede caminar");
}