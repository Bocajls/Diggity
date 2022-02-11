namespace Diggidy.Models.Abstract.PlayerShipInventory
{
    public interface IInventory
    {
        public IType[,] Items { get; set; }
    }
}