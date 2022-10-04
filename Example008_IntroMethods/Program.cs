

int a1 = 10;
int b1 = 20;
int c1 = 30;
int a2 = 40;
int b2 = 50;
int c2 = 60;
int a3 = 70;
int b3 = 80;
int c3 = 90;

int max = a1;

if(b1 > max) max = b1;
if(c1 > max) max = c1;
if(a2 > max) max = a2;
if(b2 > max) max = b2;
if(c2 > max) max = c2;
if(a3 > max) max = a3;
if(b3 > max) max = b3;
if(c3 > max) max = c3;

Console.WriteLine(max);
