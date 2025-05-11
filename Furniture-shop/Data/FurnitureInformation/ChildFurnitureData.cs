
using static SpecificationSheet;

public static class ChildFurnitureData
{
    public static List<StandartProduct> ChildFurnitureList = 
    [
        new StandartProduct { Name = "Двухстворчатый шкаф Смарти Совята", BasePrice =  10586M,
        Width = 700, Height = 2030, Depth = 450, BodyMaterial = MaterialsTypes.LaminatedChipboard,
        FacadeColor = "белый с фотопечатью Совята",
        ImageUrl="img/products/Детская мебель/Двухстворчатый шкаф Смарти Совята.jpg"},

        new StandartProduct { Name = "Навесная полка Смарти Совята", BasePrice = 2790M,
        Width = 1100, Height = 340, Depth = 316, BodyMaterial = MaterialsTypes.LaminatedChipboard,
        FacadeColor = "белый с фотопечатью Совята",
        ImageUrl="img/products/Детская мебель/Навесная полка Смарти Совята.jpg"},

        new StandartProduct { Name = "Четырехстворчатый шкаф Розалия 24", BasePrice = 2790M,
        Width = 1600, Height = 2134, Depth = 544, BodyMaterial = MaterialsTypes.LaminatedChipboard_16,
        FacadeMaterial = MaterialsTypes.MDF_16, BodyColor = "лиственница белая",
        FacadeColor = "Омела глянец металлик", Edge = EdgeTypes.PVC_045, MaximumLoadPerShelf = 10,
        ImageUrl="img/products/Детская мебель/Четырехстворчатый шкаф Розалия 24.jpg"},

        new StandartProduct { Name = "Модульная детская Дастин", BasePrice = 2790M,
        BodyMaterial = MaterialsTypes.LaminatedChipboard,
        FacadeColor = "Дуб Крафт Золотой /Белая Аляска/ Желтый",
        ImageUrl="img/products/Детская мебель/Модульная детская Дастин.jpg"},
    ];
}

