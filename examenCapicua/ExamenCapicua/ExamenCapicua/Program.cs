// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int numero = 114;
string numconvertido = numero.ToString();
string alRevez = "";

for (int i = 0; i < numconvertido.Length; i++)
{
    
    alRevez = numconvertido[i] + alRevez;
}
    Console.WriteLine(alRevez);

if(numconvertido == alRevez)
{
    Console.WriteLine("Es número capicua");
}
else
{
    Console.WriteLine("No es capicua");
}


for(int k = 10; k > 0; k--)
{
    Console.WriteLine(k);
}
 
