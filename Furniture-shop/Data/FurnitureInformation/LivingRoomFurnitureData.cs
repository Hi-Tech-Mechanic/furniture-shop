using static SpecificationSheet;

public static class LivingRoomFurnitureData
{
    public static List<StandartProduct> LivingRoomFurnitureList =
    [
        new StandartProduct {
            Name = "Стенка Макарена МДФ", BasePrice =  38316M,
            Width = 2790,
            Height = 2000,
            Depth = 440,
            BodyMaterial = MaterialsTypes.LaminatedChipboard,
            FacadeMaterial = MaterialsTypes.LaminatedChipboard_Glass, Edge = EdgeTypes.PVC_04, BodyColor = "венге",
            FacadeColor = "дуб", Guides = GuidesTypes.Roller, MaximumLoadPerShelf = 5,
            ImageUrl="img/products/Мебель для гостинной/Стенка Макарена МДФ.jpg"
        },

        new StandartProduct
        {
            Name = "Гостиная Дельта",
            BasePrice = 18526M,
            Width = 2648,
            Height = 1874,
            Depth = 456,
            BodyMaterial = MaterialsTypes.LaminatedChipboard,
            FacadeMaterial = MaterialsTypes.LaminatedChipboard_Glass,
            Edge = EdgeTypes.PVC_04,
            FacadeColor = Colors.White,
            MaximumLoadPerShelf = 5,
            ImageUrl = "img/products/Мебель для гостинной/Гостиная Дельта.jpg"
        },

        new StandartProduct
        {
            Name = "Стенка Лима",
            BasePrice = 8916M,
            Width = 1500,
            Height = 1500,
            Depth = 440,
            BodyMaterial = MaterialsTypes.LaminatedChipboard,
            FacadeMaterial = MaterialsTypes.LaminatedChipboard,
            Edge = EdgeTypes.PVC_04,
            MaximumLoadPerShelf = 5,
            ImageUrl = "img/products/Мебель для гостинной/Стенка Лима.jpg"
        },

        new StandartProduct
        {
            Name = "Гостиная Пекин",
            BasePrice = 13377M,
            Width = 2100,
            Height = 1785,
            Depth = 398,
            BodyMaterial = MaterialsTypes.LaminatedChipboard,
            FacadeMaterial = MaterialsTypes.LaminatedChipboard,
            Edge = EdgeTypes.PVC_04,
            Guides = GuidesTypes.Roller,
            MaximumLoadPerShelf = 5,
            ImageUrl = "img/products/Мебель для гостинной/Гостиная Пекин.jpg"
        },

        new StandartProduct
        {
            Name = "Журнальный стол СЖ-1",
            BasePrice = 3324M,
            Width = 820,
            Height = 600,
            Depth = 529,
            BodyMaterial = MaterialsTypes.LaminatedChipboard,
            ImageUrl = "img/products/Мебель для гостинной/Журнальный стол СЖ-1.jpg"
        }
    ];
}
