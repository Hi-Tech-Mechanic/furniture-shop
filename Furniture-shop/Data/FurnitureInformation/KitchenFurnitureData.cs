
using static SpecificationSheet;

public static class KitchenFurnitureData
{
    public static List<StandartProduct> KitchenFurnitureList = 
    [
        new StandartProduct { Name = "Кухня 1.6 Маша-2", BasePrice =  15866M,
        Width = 1600, Height = 2100, Depth = 600, BodyMaterial = "ЛДСП, Стекло тонированное 4 мм",
        FacadeMaterial = MaterialsTypes.LaminatedChipboard, Guides = GuidesTypes.Roller,
        HandleMaterial = MaterialsTypes.Plastic,
        ImageUrl="img/products/Кухонная мебель/Кухня 1.6 Маша-2.jpg"},

        new StandartProduct { Name = "Кухня Дана 1.0", BasePrice =  8333M,
        Width = 1000, Height = 2110, Depth = 600, BodyMaterial = MaterialsTypes.LaminatedChipboard,
        FacadeMaterial = MaterialsTypes.LaminatedChipboard, BodyColor = "Дуб Крафт золотой",
        HandleMaterial = MaterialsTypes.Plastic, FacadeColor = Colors.White, Guides = GuidesTypes.Roller,
        ImageUrl="img/products/Кухонная мебель/Кухня Дана 1.0.jpg"},

        new StandartProduct { Name = "Полукруглый стол-тумба", BasePrice =  5137M,
        Width = 900, Height = 780, Depth = 290, BodyMaterial = MaterialsTypes.LaminatedChipboard_16,
        Edge = EdgeTypes.PVC_045, ImageUrl="img/products/Кухонная мебель/Полукруглый стол-тумба.jpg"},

        new StandartProduct { Name = "Стул Венсен", BasePrice =  8861M,
        Width = 555, Height = 900, Depth = 600,
        BodyMaterial = "Рамка из массива, пружина – змейка, ППУ – 40мм, гнутоклееная фанера 10 мм",
        UpholsteryMaterial = "велюр", ImageUrl="img/products/Кухонная мебель/Стул Венсен.jpg"},

        new StandartProduct { Name = "Кухонный уголок Трапэзи Тессера", BasePrice =  12225M,
        Width = 1582, Height = 990, Depth = 1182,
        BodyMaterial = MaterialsTypes.LaminatedChipboard + ", кожзам",
        ImageUrl="img/products/Кухонная мебель/Кухонный уголок Трапэзи Тессера.jpg"},

        new StandartProduct { Name = "Кухонный уголок Орхидея Комби", BasePrice =  19239M,
        Width = 1080, Height = 880, Depth = 1480, UpholsteryMaterial = FillTypes.ECO_leather,
        Edge = EdgeTypes.PVC, Filler = FillTypes.Polyurethane, MaximumLoad = 120,
        BodyMaterial = MaterialsTypes.LaminatedChipboard + ", " + MaterialsTypes.Plastic,
        ImageUrl="img/products/Кухонная мебель/Кухонный уголок Орхидея Комби.jpg"},

        new StandartProduct { Name = "Табурет Экстра", BasePrice =  1657M,
        Width = 360, Height = 480, Depth = 360,
        BodyMaterial = "металл, фанера", UpholsteryMaterial = FillTypes.ECO_leather,
        Filler = FillTypes.Polyurethane, BodyColor = "металлик", MaximumLoad = 120,
        ImageUrl="img/products/Кухонная мебель/Табурет Экстра.jpg"},
    ];
}

