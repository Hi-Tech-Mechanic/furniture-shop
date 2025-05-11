public class BaseCharacteristics
{
    public int Id { get; set; }

    public required string Name { get; set; }

    public required decimal BasePrice { get; set; }

    public int? Width { get; set; }

    public int? Height { get; set; }

    public int? Depth { get; set; }

    public required string ImageUrl { get; set; }

    public string GetFormattedBasePrice() => BasePrice.ToString("0 000 ₽");
}

public class StandartProduct : BaseCharacteristics
{
    public string? BodyMaterial {get; set; }

    public string? FacadeMaterial {get; set; }

    public string? UpholsteryMaterial {get; set; }

    public string? HandleMaterial {get; set; }

    public string? Edge {get; set; }

    public string? BodyColor {get; set; }

    public string? FacadeColor {get; set; }

    public string? Guides {get; set; }

    public string? Filler {get; set; }

    public string? Assembly {get; set; }

    public int? MaximumLoad {get; set; }

    public int? MaximumLoadPerShelf {get; set; }
}

public class Sofas : BaseCharacteristics
{
    public string? BodyMaterial {get; set; }

    public string? UpholsteryMaterial {get; set; }

    public string? Filler {get; set; }

    public string? PadsOnArmrests {get; set; }  

    public int? MaximumLoad {get; set; }

    public int? SeatHeight {get; set; }

    public int? SeatDepth {get; set; }

    public string? Frame {get; set; }

    public string? Mattress {get; set; }

    public string? Case {get; set; }

    public string? TransformationMechanism {get; set; }
}

public class Mattress: BaseCharacteristics
{
    public string? Rigidity {get; set; }    
    public int? LoadWeight {get; set; }
    public string? Case {get; set;}
    public List<string>? Composition {get; set; }
}