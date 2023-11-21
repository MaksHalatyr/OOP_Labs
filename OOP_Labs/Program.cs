using Lab5.Task1;
using Lab5.Task2;
using Lab5.Task3;

Rectangle rectangle1 = new Rectangle { FirstDimension = 5, SecondDimension = 10 };
Rectangle rectangle2 = new Rectangle { FirstDimension = 3, SecondDimension = 7 };
Rectangle rectangle3 = new Rectangle { FirstDimension = 8, SecondDimension = 4 };

ColoredRectangle coloredRectangle1 = new ColoredRectangle { FirstDimension = 6, SecondDimension = 9, Color = "Red" };
ColoredRectangle coloredRectangle2 = new ColoredRectangle { FirstDimension = 4, SecondDimension = 12, Color = "Blue" };
ColoredRectangle coloredRectangle3 = new ColoredRectangle { FirstDimension = 7, SecondDimension = 5, Color = "Green" };

// Створення масиву
IFigure[] figures = { rectangle1, rectangle2, rectangle3, coloredRectangle1, coloredRectangle2, coloredRectangle3 };

// Вивід тільки тих елементів, які підтримують колір
Console.WriteLine("Figures with Color:");
foreach (var figure in figures)
{
    if (figure is IColoredFigure colored)
    {
        colored.DisplayType();
        colored.DisplayColor();
    }
}

// Створення масиву Інструментів
IInstrument[] instruments = {
            new Guitar { NumberOfStrings = 6 },
            new Drum { Size = 22 },
            new Trumpet { Diameter = 0.5 }
        };

// Виклик методу Play() для кожного інструменту
foreach (var instrument in instruments)
{
    instrument.Play();
}

Shop[] sizes = new Shop[]
        {
            new Shop(ClothingSize.XXS, 32),
            new Shop(ClothingSize.XS, 34),
            new Shop(ClothingSize.S, 36),
            new Shop(ClothingSize.M, 38),
            new Shop(ClothingSize.L, 40),
        };

IMaleClothing[] maleClothes = new IMaleClothing[]
{
            new TShirt(ClothingSize.S, 25.0m, "Blue"),
            new Pants(ClothingSize.M, 40.0m, "Black"),
            new Tie(ClothingSize.L, 15.0m, "Red"),
};

IFemaleClothing[] femaleClothes = new IFemaleClothing[]
{
            new TShirt(ClothingSize.XS, 20.0m, "Pink"),
            new Pants(ClothingSize.S, 35.0m, "Gray"),
            new Skirt(ClothingSize.M, 30.0m, "Blue"),
};

Atelier atelier = new Atelier();
atelier.DressWoman(femaleClothes);
atelier.DressMan(maleClothes);