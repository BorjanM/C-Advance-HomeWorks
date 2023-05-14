
using HomeWork_od_sesti_cas.Entities;
#region
Person jeff = new Person();
jeff.FirstName = "Jeff";
jeff.LastName = "Jefferson";
jeff.Age = 30;
jeff.NumberOfDogs = 2;
Database.personList.Add(jeff);

Dog jinger = new Dog();
jinger.Name = "Jinger";
jinger.AgeOfDog = 3;
jinger.DogsColor = "white";
jinger.NameOfOwner = "Jeff";
Database.dogList.Add(jinger);

Dog juki = new Dog();
jinger.Name = "Juki";
jinger.AgeOfDog = 2;
jinger.DogsColor = "brown";
jinger.NameOfOwner = "Jeff";
Database.dogList.Add(juki);

Person rorry = new Person();
rorry.FirstName = "Rorry";
rorry.LastName = "Rorrison";
rorry.Age = 58;
rorry.NumberOfDogs = 2;
Database.personList.Add(rorry);

Dog randy = new Dog();
randy.Name = "Randy";
randy.AgeOfDog = 2;
randy.DogsColor = "brown";
randy.NameOfOwner = "Rorry";
Database.dogList.Add(randy);

Dog ris = new Dog();
ris.Name = "Riss";
ris.AgeOfDog = 3;
ris.DogsColor = "brown";
ris.NameOfOwner = "Jeff";
Database.dogList.Add(ris);

Person cristofer = new Person();
cristofer.FirstName = "Cristopher";
cristofer.LastName = "Cristopherson";
cristofer.Age = 64;
cristofer.NumberOfDogs = 1;
Database.personList.Add(cristofer);

Dog cesar = new Dog();
cesar.Name = "Cesar";
cesar.AgeOfDog = 3;
cesar.DogsColor = "brown";
cesar.NameOfOwner = "Cristopher";
Database.dogList.Add(cesar);


Person freddy = new Person();
freddy.FirstName = "Freddy";
freddy.LastName = "Fredilowski";
freddy.Age = 27;
freddy.NumberOfDogs = 3;
Database.personList.Add(freddy);

Dog fury = new Dog();
fury.Name = "Fury";
fury.AgeOfDog = 1;
fury.DogsColor = "white";
fury.NameOfOwner = "Freddy";
Database.dogList.Add(fury);

Dog fiesta = new Dog();
fiesta.Name = "Fiesta";
fiesta.AgeOfDog = 3;
fiesta.DogsColor = "black";
fiesta.NameOfOwner = "Freddy";
Database.dogList.Add(fiesta);

Person erin = new Person();
erin.FirstName = "Erin";
erin.LastName = "Erinson";
erin.Age = 27;
erin.NumberOfDogs = 2;
Database.personList.Add(erin);

Dog eros = new Dog();
eros.Name = "Erros";
eros.AgeOfDog = 4;
eros.DogsColor = "brown";
eros.NameOfOwner = "Erin";
Database.dogList.Add(eros);

Dog egal = new Dog();
egal.Name = "Eggal";
egal.AgeOfDog = 3;
egal.DogsColor = "white";
egal.NameOfOwner = "Erin";
Database.dogList.Add(egal);


Person amelia = new Person();
amelia.FirstName = "Amelia";
amelia.LastName = "Amilson";
amelia.Age = 45;
amelia.NumberOfDogs = 2;
Database.personList.Add(amelia);

Dog asy = new Dog();
asy.Name = "Assy";
asy.AgeOfDog = 5;
asy.DogsColor = "black";
asy.NameOfOwner = "Amelia";
Database.dogList.Add(asy);

Dog arie = new Dog();
arie.Name = "Arie";
arie.AgeOfDog = 4;
arie.DogsColor = "black";
arie.NameOfOwner = "Amelia";
Database.dogList.Add(arie);

Dog neron = new Dog();
neron.Name = "Neron";
neron.AgeOfDog = 4;
neron.DogsColor = "black";
neron.NameOfOwner = "Nathen";
Database.dogList.Add(neron);

#endregion


//Find and print all persons firstnames starting with 'R', ordered by Age - DESCENDING ORDER
Console.WriteLine("----------------------------");
Console.WriteLine("Printing all persons firstnames starting with 'R', ordered by Age - DESCENDING ORDER: ");
Console.WriteLine("");

List<Person> firstNamesStartingWithR = Database.personList.Where(x => x.FirstName.StartsWith("R")).OrderByDescending(x => x.Age).ToList();
foreach (Person p in firstNamesStartingWithR)
{
    Console.WriteLine(p.FirstName + " " + p.Age);
}


//Find and print all brown dogs names and ages older than 3 years, ordered by Age - ASCENDING ORDER
Console.WriteLine("----------------------------");
Console.WriteLine("Printing all brown dogs names and ages older than 3 years, ordered by Age - ASCENDING ORDER: ");
Console.WriteLine("");

List<Dog> allBrownDogsNamesOlderThanThree = Database.dogList.Where(x => x.DogsColor == "brown").Where(x => x.AgeOfDog > 3).OrderBy(y => y.AgeOfDog).ToList();

foreach (Dog d in allBrownDogsNamesOlderThanThree)
{
    Console.WriteLine(d.Name + " " + d.AgeOfDog);
}


//Find and print all persons with more than 2 dogs, ordered by Name - DESCENDING ORDER
Console.WriteLine("----------------------------");
Console.WriteLine("Printing all persons with more than 2 dogs, ordered by Name - DESCENDING ORDER: ");
Console.WriteLine("");

List<Person> allPersonsWithMoreThanTwoDogs = Database.personList.Where(x => x.NumberOfDogs > 2).OrderByDescending(y => y.FirstName).ToList();

foreach (Person p in allPersonsWithMoreThanTwoDogs)
{
    Console.WriteLine(p.FirstName + " " + p.NumberOfDogs);
}


//Find and print all Freddy`s dogs names older than 1 year
Console.WriteLine("----------------------------");
Console.WriteLine("Printing all Freddy`s dogs names older than 1 year: ");
Console.WriteLine("");

List<Dog> allFreddyDogsOlderThanOneYear = Database.dogList.Where(x => x.NameOfOwner == "Freddy").OrderBy(y => y.AgeOfDog > 1).ToList();

foreach (Dog d in allFreddyDogsOlderThanOneYear)
{
    Console.WriteLine(d.Name + " " + d.AgeOfDog);
}

//Find and print Nathen`s first dog
Console.WriteLine("----------------------------");
Console.WriteLine("Printing Nathen`s first dog: ");
Console.WriteLine("");

List<Dog> nathensFirstDog = Database.dogList.Where(x => x.NameOfOwner == "Nathen").OrderByDescending(y => y.AgeOfDog).ToList();

foreach (Dog d in nathensFirstDog)
{
    Console.WriteLine(d.Name + " " + d.AgeOfDog);
}

//Find and print all white dogs names from Cristofer, Freddy, Erin and Amelia, ordered by Name - ASCENDING ORDER
Console.WriteLine("----------------------------");
Console.WriteLine("Printing all white dogs names from Cristofer, Freddy, Erin and Amelia, ordered by Name - ASCENDING ORDER: ");
Console.WriteLine("");

List<Dog> allWhiteDogNamesFromCFEA = Database.dogList.Where(x => x.NameOfOwner == "Cristopher" || x.NameOfOwner == "Erin" || x.NameOfOwner == "Amelia" || x.NameOfOwner == "Freddy").Where(x => x.DogsColor == "white").OrderBy(y => y.Name).ToList();

foreach (Dog d in allWhiteDogNamesFromCFEA)
{
    Console.WriteLine(d.Name + " " + d.DogsColor);
}