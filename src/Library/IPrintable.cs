namespace Full_GRASP_And_SOLID;

public interface IPrintable
{
    Product FinalProduct { get; set; }
    void AddStep(Product product, int quantity, Equipment equipment, int time);
    void AddStep(string action, int time);
    int GetProductionCost();
    string GetTextToPrint();
}