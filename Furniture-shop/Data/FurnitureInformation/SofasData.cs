using static SpecificationSheet;

public static class SofasData
{
    public static List<Sofas> SofasList =
    [
        new Sofas { Name = "Прямой диван-кровать Колорадо", BasePrice =  74130M,
        Width = 1800, Height = 860, Depth = 1090, SeatHeight = 44,
        Frame = FrameTypes.MetalFrame, Mattress = "комфорт",
        TransformationMechanism = TransformationMechanismTypes.Accordion, MaximumLoad = 120,
        ImageUrl="img/products/Мягкая мебель/Прямой диван-кровать Колорадо.jpg"},

        new Sofas { Name = "Пуф Классик", BasePrice =  4488M,
        Width = 460, Height = 450, Depth = 460, SeatHeight = 45, SeatDepth = 46,
        BodyMaterial = MaterialsTypes.LaminatedChipboard, UpholsteryMaterial = FillTypes.ECO_leather, Filler = FillTypes.Polyurethane, MaximumLoad = 120, ImageUrl="img/products/Мягкая мебель/Пуф Классик.jpg"},

        new Sofas { Name = "Прямой диван-кровать двойной Манхэттен", BasePrice =  73861M,
        Width = 2640, Height = 910, Depth = 900, SeatHeight = 45, Frame = FrameTypes.MetalFrame,
        PadsOnArmrests = "МДФ под пленкой ПВХ, 16мм", Mattress = MattressTypes.Comfort, TransformationMechanism = TransformationMechanismTypes.Sergio,
        MaximumLoad = 120, Case = CaseTypes.Removable, ImageUrl="img/products/Мягкая мебель/Прямой диван-кровать двойной Манхэттен.jpg"},

        new Sofas { Name = "Прямой диван-кровать Парма", BasePrice =  48528M,
        Width = 1900, Height = 980, Depth = 1030, SeatHeight = 48, Frame = FrameTypes.MetalFrame,
        PadsOnArmrests = "МДФ под пленкой ПВХ, 16мм", Mattress = MattressTypes.SuperComfort, TransformationMechanism = TransformationMechanismTypes.Click_Clack,
        MaximumLoad = 120, ImageUrl="img/products/Мягкая мебель/Прямой диван-кровать Парма.jpg"},

        new Sofas { Name = "Прямой диван-кровать Сиэтл", BasePrice =  104755M,
        Width = 2460, Height = 900, Depth = 1100, SeatHeight = 45, SeatDepth = 60,
        Frame = FrameTypes.MetalFrame, Mattress = "13 см., " + MattressTypes.SuperComfort, TransformationMechanism = TransformationMechanismTypes.Pantograph,
        MaximumLoad = 200, Case = CaseTypes.Removable, ImageUrl="img/products/Мягкая мебель/Прямой диван-кровать Сиэтл.jpg"},

        new Sofas { Name = "Диван Кредо ППУ", BasePrice =  53883M,
        Width = 2270, Height = 920, Depth = 900, SeatHeight = 43, SeatDepth = 7560,
        TransformationMechanism = TransformationMechanismTypes.Tick_tock, Case = CaseTypes.NonRemovable,
        ImageUrl="img/products/Мягкая мебель/Диван Кредо ППУ.jpg"},

        new Sofas { Name = "Прямой диван-кровать Милан", BasePrice =  86258M,
        Width = 2040, Height = 1090, Depth = 1060, SeatHeight = 48, SeatDepth = 63,
        Frame = FrameTypes.MetalFrame, Mattress = "14 см., " + MattressTypes.Comfort, TransformationMechanism = TransformationMechanismTypes.Click_Clack,
        MaximumLoad = 120, Case = CaseTypes.Removable, ImageUrl="img/products/Мягкая мебель/Прямой диван-кровать Милан.jpg"},

        new Sofas { Name = "Угловой диван Кембридж", BasePrice =  163555M,
        Width = 2750, Height = 1000, Depth = 1620, SeatHeight = 50, SeatDepth = 60,
        Frame = FrameTypes.MetalFrame, Mattress = "17 см., люкс, с независимым пружинным блоком", TransformationMechanism = TransformationMechanismTypes.Pantograph,
        MaximumLoad = 300, Case = CaseTypes.Removable, ImageUrl="img/products/Мягкая мебель/Угловой диван Кембридж.jpg"},
    ];
}
