// Поиск максимального из 9 чисел
int a1 = 22;
int b1 = 50;
int c1 = 13;
int a2 = 44;
int b2 = 86;
int c2 = 998;
int a3 = 64;
int b3 = 102;
int c3 = 14;

int max = a1;
if (b1 > max) max = b1;
if (c1 > max) max = c1;

if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;

if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (c3 > max) max = c3;

Console.WriteLine(max);