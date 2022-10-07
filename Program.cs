//Random Name generator

Random r = new Random();
string[] firstname = new string[10]
{"Bill", "Joe", "Mike", "Allie", "Frank", "Sarah", "Lara", "Jake", "Maddy", "Phil"};
string[] middlename = new string[10]
{"Francis", "Carol", "Russ", "Opie", "Ivy", "Cade", "Tony", "Grey", "Lee", "Michael"};
string[] lastname = new string[10]
{"Sinatra","Christensen","Smith","Walker","Cobb","Thompson","Adams","Foster","Griffin","Hansen"};
string[] fullnames = new string[1000];
string[] job = new string[10]
{"Physicist","Asronaut","Teacher","Spy","Bartender","Cabbie","Test Dummy","Assasin","Construction Worker","Coder",};
double[] Decimal = new double[]{.25,.5,.75};
int numberlist = 0;

for (int x = 0; x < firstname.Length; x++)
    {
        for (int y = 0; x < middlename.Length; y++)
            {
                for (int z = 0; z < lastname.Length; z++)
                    {
                    int randomdecimal = r.Next(0,3);
                    int random = r.Next(0, 5);
                    int randomwage = r.Next(7,80);
                    double wage = (double)randomwage;
                    wage = wage + Decimal[randomdecimal];
                    fullnames[x] = firstname[x] + middlename[y] + lastname[z] + job[random];
                    numberlist++;
                    Console.WriteLine($"{numberlist}: {fullnames[x]}: hourly wage: ${wage}, yearly income: ${wage*48*40}");
                    }
            }
    }
