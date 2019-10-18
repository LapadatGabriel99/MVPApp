namespace CommonComponents.Presentation
{
    public interface IAccessTypeEventArgs
    {
        AccessType AccessTypeValue { get; set; }
        bool ValuesWereChanged { get; set; }
    }
}