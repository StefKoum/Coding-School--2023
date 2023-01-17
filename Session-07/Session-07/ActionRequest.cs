using System;

public class ActionRequest
{
    public Guid RequestID { get; set; }
    public string? Input { get; set; }
    public Action ActionEnum { get; set; }
}
