namespace Builder
{
    public interface IInterfaceBuilder
    {
        IInterfaceBuilder BuildLeftColumn();
        IInterfaceBuilder BuildMiddleTopImages();
        IInterfaceBuilder BuildImages();
        IInterfaceBuilder BuildBottomBtns();
        IInterfaceBuilder Init();
    }
}