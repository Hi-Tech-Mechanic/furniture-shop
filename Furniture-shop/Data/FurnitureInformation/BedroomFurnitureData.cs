
using static SpecificationSheet;

public static class BedroomFurnitureData
{
    public static List<StandartProduct> BedroomFurnitureList = 
    [
        new StandartProduct { Name = "Комод Чарли 9.1", BasePrice =  12759M,
        Width = 1400, Height = 714, Depth = 460, BodyMaterial = MaterialsTypes.LaminatedChipboard,
        Edge = EdgeTypes.PVC_045 + " в цвет ЛДСП", BodyColor = Colors.Cashmere, ImageUrl="img/products/Мебель для спальни/Комод Чарли 9.1.jpg"},

        new StandartProduct { Name = "Кровать Victor", BasePrice =  7154M,
        Width = 1634, Height = 676, Depth = 2046, BodyMaterial = MaterialsTypes.LaminatedChipboard,
        Edge = EdgeTypes.PVC_04, MaximumLoad = 100, ImageUrl="img/products/Мебель для спальни/Кровать Victor.jpg"},

        new StandartProduct { Name = "Кровать Юнона", BasePrice =  5817M,
        Width = 1600, Height = 842, Depth = 2050, BodyMaterial = MaterialsTypes.LaminatedChipboard,
        Edge = EdgeTypes.PVC_04, BodyColor = "венге/дуб", MaximumLoad = 100, ImageUrl="img/products/Мебель для спальни/Кровать Юнона.jpg"},

        new StandartProduct { Name = "Комод Ливерпуль 10.103", BasePrice =  18260M,
        Width = 1003, Height = 953, Depth = 413, BodyMaterial = MaterialsTypes.LaminatedChipboard_16,
        FacadeMaterial = MaterialsTypes.MDF_16, Edge = EdgeTypes.PVC_04,
        BodyColor = "белый с тиснением “Поры дерева”", FacadeColor = "ясень ваниль",
        ImageUrl="img/products/Мебель для спальни/Комод Ливерпуль 10.103.jpg"},

        new StandartProduct { Name = "Кровать Ронда", BasePrice =  4699M,
        Width = 1635, Height = 700, Depth = 2032, BodyMaterial = MaterialsTypes.LaminatedChipboard,
        FacadeMaterial = MaterialsTypes.LaminatedChipboard,
        ImageUrl="img/products/Мебель для спальни/Кровать Ронда.jpg"},

        new StandartProduct { Name = "Трехстворчатый шкаф Акация", BasePrice =  23377M,
        Width = 1200, Height = 2200, Depth = 520, BodyMaterial = MaterialsTypes.LaminatedChipboard,
        Guides = GuidesTypes.Ballpoint, ImageUrl="img/products/Мебель для спальни/Трехстворчатый шкаф Акация.jpg"},
    ];
}

