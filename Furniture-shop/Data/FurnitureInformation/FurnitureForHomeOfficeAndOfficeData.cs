using static SpecificationSheet;

public static class FurnitureForHomeOfficeAndOfficeData
{
    public static List<StandartProduct> FurnitureForHomeOfficeAndOfficeList =
    [
        new StandartProduct { Name = "Стол Лайт", BasePrice =  6041M,
        Width = 1200, Height = 750, Depth = 596, BodyMaterial = MaterialsTypes.LaminatedChipboard,
        FacadeMaterial = MaterialsTypes.LaminatedChipboard, Edge = EdgeTypes.PVC_04,
        BodyColor = "дуб крафт золотой/белый", FacadeColor = Colors.White, Guides = GuidesTypes.Roller,
        MaximumLoadPerShelf = 5,
        ImageUrl="img/products/Мебель для домашнего кабинета и офиса/Стол Лайт.jpg"},

        new StandartProduct { Name = "Стол руководителя 1900 Акцент", BasePrice =  7641M,
        Width = 1900, Height = 700, Depth = 770, BodyMaterial = MaterialsTypes.LaminatedChipboard,
        Edge = EdgeTypes.PVC_04, BodyColor = "Ясень Шимо светлый",
        ImageUrl="img/products/Мебель для домашнего кабинета и офиса/Стол руководителя 1900 Акцент.jpg"},

        new StandartProduct { Name = "Письменный стол Asti-3", BasePrice =  5507M,
        Width = 1100, Height = 750, Depth = 506, BodyMaterial = MaterialsTypes.LaminatedChipboard,
        Edge = EdgeTypes.PVC_08, MaximumLoadPerShelf = 10,
        ImageUrl="img/products/Мебель для домашнего кабинета и офиса/Письменный стол Asti-3.jpg"},

        new StandartProduct { Name = "Письменный стол Asti-1", BasePrice =  5507M,
        Width = 800, Height = 750, Depth = 478, BodyMaterial = MaterialsTypes.LaminatedChipboard,
        Edge = EdgeTypes.PVC_08, MaximumLoadPerShelf = 8,
        ImageUrl="img/products/Мебель для домашнего кабинета и офиса/Письменный стол Asti-1.jpg"},

        new StandartProduct { Name = "Письменный стол Ронда СТП", BasePrice =  1782M,
        Width = 1200, Height = 750, Depth = 570, BodyMaterial = MaterialsTypes.LaminatedChipboard,
        FacadeMaterial = MaterialsTypes.LaminatedChipboard, HandleMaterial = MaterialsTypes.Plastic,
        BodyColor = "венге", FacadeColor = "дуб Белфорд", Guides = GuidesTypes.Roller,
        Assembly = "Универсальная (зеркальная) сборка конструкцией не предусмотрена",
        ImageUrl="img/products/Мебель для домашнего кабинета и офиса/Письменный стол Ронда СТП.jpg"},

        new StandartProduct { Name = "Компьютерный стол Олимп", BasePrice =  5507M,
        Width = 1200, Height = 1550, Depth = 500, BodyMaterial = MaterialsTypes.LaminatedChipboard,
        Assembly = "Универсальная (зеркальная) сборка конструкцией не предусмотрена",
        ImageUrl="img/products/Мебель для домашнего кабинета и офиса/Компьютерный стол Олимп.jpg"},

        new StandartProduct { Name = "Компьютерный стол СК-11", BasePrice =  10285M,
        Width = 1400, Height = 800, Depth = 1200, Edge = EdgeTypes.PVC_04,
        BodyMaterial = MaterialsTypes.LaminatedChipboard,
        Assembly = "Односторонняя",
        ImageUrl="img/products/Мебель для домашнего кабинета и офиса/Компьютерный стол СК-11.jpg"},

        new StandartProduct { Name = "Книжная полка 6", BasePrice =  10285M,
        Width = 1190, Height = 600, Depth = 240, Edge = EdgeTypes.PVC,
        BodyMaterial = MaterialsTypes.LaminatedChipboard, BodyColor = "ясень Шимо темный",
        ImageUrl="img/products/Мебель для домашнего кабинета и офиса/Книжная полка 6.jpg"},
    ];
}
