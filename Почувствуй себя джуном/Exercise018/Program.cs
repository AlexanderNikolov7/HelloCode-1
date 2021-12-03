Console.WriteLine("Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y");
bool X = true;
bool Y = true;
 
bool XorY = X | Y; 
bool notXorY = !XorY;

bool notX = !X;
bool notY = !Y;
bool notXandNotY = notX & notY;

bool result = notXorY == notXandNotY;
Console.WriteLine(result);
