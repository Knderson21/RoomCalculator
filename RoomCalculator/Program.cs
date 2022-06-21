//Intro
Console.WriteLine("Welcome to the Room Detail Generator!");

//Enter info
Console.WriteLine("Enter Length: ");
double Length = double.Parse(Console.ReadLine());

Console.WriteLine("Enter Width: ");
double Width = double.Parse(Console.ReadLine());

Console.WriteLine("Enter Height: ");
double Height = double.Parse(Console.ReadLine());

//Calulate Area
double Area = Length * Width;
Console.WriteLine("Area: " + Area);

//Calculate Perimeter
double Perimeter = 2 * (Length + Width);
Console.WriteLine("Perimeter: " + Perimeter);

//Calculate Volume
double Volume = Length * Width * Height;
Console.WriteLine("Volume: " + Volume);

//Calculate Surface Area
double SurfaceArea = 2 * (Length * Width + Width * Height + Length * Height);
Console.WriteLine("Surface Area: " + SurfaceArea);

if(Area <= 250)
{
    Console.WriteLine("This is a small sized room.");
}
else if(Area > 250 && Area < 650)
        {
    Console.WriteLine("This is a medium sized room.");
}
else if(Area >= 650)
        {
    Console.WriteLine("This is a large sized room.");
}

//Closing remarks
Console.WriteLine("Thank you for using the Room Detail Generator!");