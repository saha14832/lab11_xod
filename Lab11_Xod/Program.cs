
int[] group = { 1, 2, 3, 4 };

int A = int.Parse(Console.ReadLine());

bool F = false;

for (int i = 0; i < group.Length; i++)
{
   if (group[i] == A)
   {
      F = true;
      break;
   }
}

if (F)
{
   Console.WriteLine("DA");
}
else
{
   Console.WriteLine("NET");
}




int[] summ = { 8, 2, 3, 7, 0, };
int sug = 0;
for (int i = 0; i < group.Length; i++)
{


foreach(int pon in summ)
{
   if (pon % 2 == 0)
   {
      continue;
   }
   sug += pon;
}
}
Console.WriteLine(sug);



int[] var1 = { 4, 6, 4, -1, 5, -1 };
int T = 0;

for (int j = 0; j < group.Length; j++)
{
   foreach (int poin in var1)
   {
      if (poin < 0)
      {
         continue;
      }
      T += var1[j];
   }
}

Console.WriteLine(T);