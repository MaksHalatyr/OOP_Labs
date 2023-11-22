using Lab_10;

char q = 'q',
    w = 'w',
    e = 'e',
    r = 'r',
    t = 't',
    y = 'y';

double[] arr = { 1.0, 2.0, 3.0 };
double[] arrr = { 2.0, 3.4, 5.7 };

CharList charList = new CharList();
CharList charList1 = new CharList();

CharSet charSet = new CharSet();
CharSet charSet1 = new CharSet();

Vector vector = new Vector(arr);
Vector vector1 = new Vector(arrr);

charList.Add(q);
charList.Add(w);
charList.Add(e);
charList.Add(r);
charList.Add(t);
charList.Add(y);
charSet.Add(q);
charSet.Add(w);
charSet.Add(e);
charSet.Add(r);
charSet.Add(t);
charSet.Add(y);

bool res = vector == vector1;
CharSet charSet2 = charSet * charSet1;
CharList charList2 = charList + charList1;
charSet2.Print();
charList2.Print();
