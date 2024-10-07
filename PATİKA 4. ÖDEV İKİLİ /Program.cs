using System.Collections;
using System.Diagnostics;

Console.WriteLine("RÜYA MANAVA HOŞGELDİN BACIM");
Console.WriteLine("Elma = 2 TL. ");
Console.WriteLine("Armut = 3 TL. ");
Console.WriteLine("Çilek = 2 TL. ");
Console.WriteLine("Muz = 3 TL. ");
Console.WriteLine("Kalanların hepsi 4 TL.");
Console.WriteLine("Ne istersin bacım ? ");
string meyve = Console.ReadLine().ToLower();

#region If Case
//to lower ile harfleri küçülttük
//if(meyve == "elma" || meyve == "çilek")
//{
//    Console.WriteLine("Seçtiğin meyve 2 TL. ");
//}
//else if(meyve == "armut" || meyve=="muz") 
//BURALARDA OR STATEMENT KULLANMAK İÇİN MANTIK EKLEDİM ÇÜNKÜ FİYATLAR AYNI
//{
//    Console.WriteLine("Seçtiğin meyve 3 TL. ");
//}
//else 
//{
//   Console.WriteLine("Seçtiğin meyve 4 TL. ");
//}
#endregion

#region Switch Case
switch(meyve)
{
case "elma" :
    Console.WriteLine("Seçtiğin meyve 2 TL. ");
break;
case "armut" :
    Console.WriteLine("Seçtiğin meyve 3 TL. ");
break;
case "çilek" :
    Console.WriteLine("Seçtiğin meyve 2 TL. ");
break;
case "muz" :
    Console.WriteLine("Seçtiğin meyve 3 TL. ");
break;
default:
    Console.WriteLine("Seçtiğin meyve 4 TL. ");
break;
}
#endregion