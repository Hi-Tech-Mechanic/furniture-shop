using static SpecificationSheet;

public static class FurnitureForTheHallwayData
{
    public static List<StandartProduct> FurnitureForTheHallwayList =
    [
        new StandartProduct { Name = "Вешалка Бостон ВШ-1", BasePrice =  9899M,
        Width = 1100, Height = 2120, Depth = 450, BodyMaterial = MaterialsTypes.LaminatedChipboard,
        FacadeMaterial = "ЛДСП, Зеркало 4 мм", HandleMaterial = "пластик",
        BodyColor = "дуб крафт серый", FacadeColor = "дуб крафт серый/Бетонный камень",
        ImageUrl="img/products/Мебель для прихожей/Вешалка Бостон ВШ-1.jpg"},

        new StandartProduct { Name = "Вешалка Айден ВШ06-1100", BasePrice =  8953M,
        Width = 1100, Height = 2000, Depth = 400, BodyMaterial = MaterialsTypes.LaminatedChipboard,
        FacadeMaterial = "ЛДСП, Зеркало", BodyColor = Colors.White, Guides = GuidesTypes.Roller,
        ImageUrl="img/products/Мебель для прихожей/Вешалка Айден ВШ06-1100.jpg"},

        new StandartProduct { Name = "Вешалка ВО-3", BasePrice =  2561M,
        Width = 600, Height = 900, Depth = 262, BodyMaterial = MaterialsTypes.LaminatedChipboard,
        Edge = EdgeTypes.PVC, BodyColor = "ясень шимо светлый",
        ImageUrl="img/products/Мебель для прихожей/Вешалка ВО-3.jpg"},

        new StandartProduct { Name = "Обувница Мини-Лайт МЛ-5", BasePrice =  8958M,
        Width = 770, Height = 450, Depth = 468, BodyMaterial = MaterialsTypes.LaminatedChipboard,
        FacadeMaterial = MaterialsTypes.LaminatedChipboard, UpholsteryMaterial = FillTypes.ECO_leather,
        Filler = "Пенополиуретан (ППУ)", Guides = GuidesTypes.Ballpoint, MaximumLoad = 120,
        ImageUrl="img/products/Мебель для прихожей/Обувница Мини-Лайт МЛ-5.jpg"},

        new StandartProduct { Name = "Обувница Танго", BasePrice =  3768M,
        Width = 600, Height = 813, Depth = 250, BodyMaterial = MaterialsTypes.LaminatedChipboard,
        FacadeMaterial = MaterialsTypes.LaminatedChipboard, Edge = EdgeTypes.PVC_04,
        BodyColor = "Кантерберри", FacadeColor = "Сонома",
        ImageUrl="img/products/Мебель для прихожей/Обувница Танго.jpg"},

        new StandartProduct { Name = "Тумба Эльза 5", BasePrice =  5825M,
        Width = 600, Height = 960, Depth = 353, BodyMaterial = MaterialsTypes.LaminatedChipboard_16,
        FacadeMaterial = MaterialsTypes.LaminatedChipboard_16, Edge = EdgeTypes.PVC_045,
        ImageUrl="img/products/Мебель для прихожей/Тумба Эльза 5.jpg"},
    ];
}

