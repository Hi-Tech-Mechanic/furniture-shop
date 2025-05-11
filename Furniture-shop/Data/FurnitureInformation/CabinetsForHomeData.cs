
using static SpecificationSheet;

public static class CabinetsForHomeData
{
    public static List<StandartProduct> CabinetsForHomeList = 
    [
        new StandartProduct { Name = "Пенал Ронда ШК-1", BasePrice =  5404M,
        Width = 400, Height = 2120, Depth = 520, BodyMaterial = MaterialsTypes.LaminatedChipboard,
        FacadeMaterial = MaterialsTypes.LaminatedChipboard, Assembly = AssemblyTypes.Universal,
        ImageUrl="img/products/Шкафы для дома/Пенал Ронда ШК-1.jpg"},

        new StandartProduct { Name = "Шкаф-купе Фортуна", BasePrice =  5404M,
        Width = 1700, Height = 2100, Depth = 600, BodyMaterial = MaterialsTypes.LaminatedChipboard,
        FacadeMaterial = MaterialsTypes.LaminatedChipboard_Glass,
        HandleMaterial = MaterialsTypes.MetallPlastic,
        ImageUrl="img/products/Шкафы для дома/Шкаф-купе Фортуна.jpg"},

        new StandartProduct { Name = "Шкаф-купе Бассо", BasePrice =  11581M,
        Width = 1300, Height = 2020, Depth = 500, BodyMaterial = MaterialsTypes.LaminatedChipboard,
        FacadeMaterial = MaterialsTypes.LaminatedChipboard_Glass,
        HandleMaterial = MaterialsTypes.Plastic,
        ImageUrl="img/products/Шкафы для дома/Шкаф-купе Бассо.jpg"},

        new StandartProduct { Name = "Стеллаж Айден СТЛ06-600", BasePrice =  4815M,
        Width = 600, Height = 2000, Depth = 350, BodyMaterial = MaterialsTypes.LaminatedChipboard,
        FacadeMaterial = MaterialsTypes.LaminatedChipboard,
        HandleMaterial = MaterialsTypes.Plastic, Guides = GuidesTypes.Roller,
        ImageUrl="img/products/Шкафы для дома/Стеллаж Айден СТЛ06-600.jpg"},

        new StandartProduct { Name = "Трехстворчатый шкаф Чарли 25", BasePrice =  23489M,
        Width = 1200, Height = 2205, Depth = 550, BodyMaterial = MaterialsTypes.LaminatedChipboard,
        FacadeMaterial = MaterialsTypes.LaminatedChipboard, Edge = EdgeTypes.PVC_045 + " и 1 мм в цвет ЛДСП",
        BodyColor = "кашемир", HandleMaterial = MaterialsTypes.Metall, Guides = GuidesTypes.Ballpoint,
        MaximumLoadPerShelf = 10, ImageUrl="img/products/Шкафы для дома/Трехстворчатый шкаф Чарли 25.jpg"},

        new StandartProduct { Name = "Шкаф-купе Victor", BasePrice =  16275M,
        Width = 1600, Height = 2100, Depth = 526, BodyMaterial = MaterialsTypes.LaminatedChipboard,
        FacadeMaterial = MaterialsTypes.LaminatedChipboard, Edge = EdgeTypes.PVC_04,
        MaximumLoadPerShelf = 5, ImageUrl="img/products/Шкафы для дома/Шкаф-купе Victor.jpg"},

        new StandartProduct { Name = "Трехстворчатый шкаф Ронда ШК-3", BasePrice =  12673M,
        Width = 1200, Height = 2120, Depth = 520, BodyMaterial = MaterialsTypes.LaminatedChipboard_Glass,
        FacadeMaterial = MaterialsTypes.LaminatedChipboard, HandleMaterial = MaterialsTypes.Plastic,
        ImageUrl="img/products/Шкафы для дома/Трехстворчатый шкаф Ронда ШК-3.jpg"},
    ];
}

